using AxWMPLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        TcpClient client;
        NetworkStream ns;
        HelperFunctions helper = new HelperFunctions();
        OpenFileDialog openFileDialog = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            try
            {
                _ = ReceiveDataAsync();
                //_ = Task.Run(() => ReceiveDataAsync());
            }
            catch (Exception ex)
            {
                AppendToLog($"Error connecting to server: {ex.Message}");
            }
        }

        private async Task ReceiveDataAsync()
        {
            try
            {
                client = new TcpClient();
                await client.ConnectAsync("127.0.0.1", 9050);
                ns = client.GetStream();
                
                AppendToLog("Connected to server.");

                byte[] buffer = new byte[1024];
                while (true)
                {
                    int bytesRead = await ns.ReadAsync(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                    {
                        break;
                    }

                    string receivedMessage = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    if (receivedMessage.Contains("file:") || receivedMessage.Contains("folder:"))
                    {
                        helper.AppendToLogFile($"{receivedMessage}", listView1);
                    }
                    else if (receivedMessage.Contains("img"))
                    {
                        int imgSize = await helper.GetLengthAsync(bytesRead, ns);

                        byte[] imgBytes = new byte[imgSize];
                        bytesRead = await ns.ReadAsync(imgBytes, 0, imgBytes.Length);
                        File.WriteAllBytes("received_img.gz", imgBytes);

                        string decompressedImg = helper.DecompressFile("received_img.gz");

                        if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                        {
                            byte[] bytes = File.ReadAllBytes(decompressedImg);
                            File.WriteAllBytes(openFileDialog.FileName, bytes);
                        }

                        pictureBox1.ImageLocation = decompressedImg;
                    }
                    else if (receivedMessage.Contains("File Content:"))
                    {
                        int fileSize = await helper.GetLengthAsync(bytesRead, ns);

                        byte[] fileBytes = new byte[fileSize];
                        bytesRead = await ns.ReadAsync(fileBytes, 0, fileBytes.Length);

                        string compressedFilePath = "received_file.gz";
                        File.WriteAllBytes(compressedFilePath, fileBytes);
                        string decompressedFilePath = helper.DecompressFile(compressedFilePath);
                        string content = File.ReadAllText(decompressedFilePath);
                        fileContent.AppendText(content);
                    }
                    else if (receivedMessage.Contains("video"))
                    {
                        int videoSize = await helper.GetLengthAsync(bytesRead, ns);

                        byte[] videoBytes = new byte[videoSize];
                        bytesRead = await ns.ReadAsync(videoBytes, 0, videoBytes.Length);

                        File.WriteAllBytes("received_video.gz", videoBytes);
                        string decompressedVideo = helper.DecompressFile("received_video.gz");
                        AxWindowsMediaPlayer axWmp = new AxWindowsMediaPlayer();
                        this.Controls.Add(axWmp);
                        Invoke((Action)(() =>
                        {
                            axWindowsMediaPlayer1.URL = decompressedVideo;
                        }));
                        //axWindowsMediaPlayer1.URL = decompressedVideo;
                    }
                    else if(receivedMessage.Contains("WEB:"))
                    {
                        int webSize = await helper.GetLengthAsync(bytesRead, ns);

                        byte[] webBytes = new byte[webSize];
                        bytesRead = await ns.ReadAsync(webBytes, 0, webBytes.Length);

                        string response = Encoding.ASCII.GetString(webBytes);
                        fileContent.Text = response;
                    }
                    else
                    {
                        AppendToLog($"Received from server: {receivedMessage}");
                    }
                }
            }
            catch (Exception ex)
            {
                AppendToLog($"Error receiving data from server: {ex.Message}");
            }
        }

        private async void send_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] data = Encoding.ASCII.GetBytes(messageContent.Text);
                messageContent.Text = String.Empty;
                await ns.WriteAsync(data, 0, data.Length);
                await ns.FlushAsync();
                AppendToLog($"Sent to server: {Encoding.ASCII.GetString(data)}");
            }
            catch (Exception ex)
            {
                AppendToLog($"Error sending data to server: {ex.Message}");
            }
        }

        private async void sendDirName_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] data = Encoding.ASCII.GetBytes(directoryBox.Text);
                directoryBox.Text = String.Empty;
                await ns.WriteAsync(data, 0, data.Length);
                await ns.FlushAsync();
            }
            catch (Exception ex)
            {
                AppendToLog($"Error sending data to server: {ex.Message}");
            }
        }

        private void AppendToLog(string message)
        {
            chatContent.AppendText(message + Environment.NewLine);
        }
        private async void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    byte[] data = Encoding.ASCII.GetBytes("file: " + openFileDialog.FileName);
                    directoryBox.Text = String.Empty;
                    await ns.WriteAsync(data, 0, data.Length);
                    await ns.FlushAsync();
                }
                catch (Exception ex)
                {
                    AppendToLog($"Error sending data to server: {ex.Message}");
                }
            }
        }
    }
}
