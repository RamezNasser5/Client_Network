using System.IO.Compression;
using System.IO;
using System.Threading.Tasks;
using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Client
{
    internal class HelperFunctions
    {
        public string DecompressFile(string compressedFilePath)
        {
            string decompressedFilePath = compressedFilePath.Replace(".gz", "");
            using (FileStream compressedFileStream = new FileStream(compressedFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream decompressedFileStream = new FileStream(decompressedFilePath, FileMode.Create, FileAccess.Write))
            using (GZipStream decompressionStream = new GZipStream(compressedFileStream, CompressionMode.Decompress))
            {
                decompressionStream.CopyTo(decompressedFileStream);
            }
            File.Delete(compressedFilePath);
            return decompressedFilePath;
        }

        public async Task<int> GetLengthAsync(int bytesRead, NetworkStream ns)
        {
            byte[] LengthBytes = new byte[1024];
            bytesRead = await ns.ReadAsync(LengthBytes, 0, LengthBytes.Length);
            int imgSize = BitConverter.ToInt32(LengthBytes, 0);
            return imgSize;
        }

        public void AppendToLogFile(string message, ListView listView1)
        {
            string[] files = message.Split(new[] { "file:" }, StringSplitOptions.RemoveEmptyEntries);

            List<string> filesAndFoldersList = new List<string>();
            foreach (string file in files)
            {
                string[] filesAndFolders = file.Split(new[] { "folder:" },
                    StringSplitOptions.RemoveEmptyEntries);
                foreach (string item in filesAndFolders)
                {
                    filesAndFoldersList.Add(item);
                }
            }

            foreach (var item in filesAndFoldersList)
            {
                listView1.Items.Add(item);
            }
        }

    }
}