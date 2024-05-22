namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fileContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.sendDirName = new System.Windows.Forms.Button();
            this.directory_name = new System.Windows.Forms.Label();
            this.directoryBox = new System.Windows.Forms.TextBox();
            this.chatBox = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            this.chatContent = new System.Windows.Forms.TextBox();
            this.messageContent = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Open = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(37, 305);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 175);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "File Content";
            // 
            // fileContent
            // 
            this.fileContent.Location = new System.Drawing.Point(442, 182);
            this.fileContent.Multiline = true;
            this.fileContent.Name = "fileContent";
            this.fileContent.Size = new System.Drawing.Size(343, 60);
            this.fileContent.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Directory Info";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(442, 95);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(434, 58);
            this.listView1.TabIndex = 42;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // sendDirName
            // 
            this.sendDirName.Location = new System.Drawing.Point(801, 32);
            this.sendDirName.Name = "sendDirName";
            this.sendDirName.Size = new System.Drawing.Size(75, 23);
            this.sendDirName.TabIndex = 41;
            this.sendDirName.Text = "Send Dir";
            this.sendDirName.UseVisualStyleBackColor = true;
            this.sendDirName.Click += new System.EventHandler(this.sendDirName_Click);
            // 
            // directory_name
            // 
            this.directory_name.AutoSize = true;
            this.directory_name.Location = new System.Drawing.Point(439, 19);
            this.directory_name.Name = "directory_name";
            this.directory_name.Size = new System.Drawing.Size(80, 13);
            this.directory_name.TabIndex = 40;
            this.directory_name.Text = "Directory Name";
            // 
            // directoryBox
            // 
            this.directoryBox.Location = new System.Drawing.Point(442, 35);
            this.directoryBox.Name = "directoryBox";
            this.directoryBox.Size = new System.Drawing.Size(311, 20);
            this.directoryBox.TabIndex = 39;
            // 
            // chatBox
            // 
            this.chatBox.AutoSize = true;
            this.chatBox.Location = new System.Drawing.Point(34, 166);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(50, 13);
            this.chatBox.TabIndex = 38;
            this.chatBox.Text = "Chat Box";
            // 
            // messageBox
            // 
            this.messageBox.AutoSize = true;
            this.messageBox.Location = new System.Drawing.Point(34, 49);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(71, 13);
            this.messageBox.TabIndex = 37;
            this.messageBox.Text = "Message Box";
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(84, 134);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 36;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // chatContent
            // 
            this.chatContent.Location = new System.Drawing.Point(37, 182);
            this.chatContent.Multiline = true;
            this.chatContent.Name = "chatContent";
            this.chatContent.Size = new System.Drawing.Size(343, 106);
            this.chatContent.TabIndex = 35;
            // 
            // messageContent
            // 
            this.messageContent.Location = new System.Drawing.Point(37, 65);
            this.messageContent.Multiline = true;
            this.messageContent.Name = "messageContent";
            this.messageContent.Size = new System.Drawing.Size(343, 42);
            this.messageContent.TabIndex = 34;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(84, 14);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 33;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(461, 262);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(415, 218);
            this.axWindowsMediaPlayer1.TabIndex = 47;
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(801, 182);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 48;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 492);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileContent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.sendDirName);
            this.Controls.Add(this.directory_name);
            this.Controls.Add(this.directoryBox);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.send);
            this.Controls.Add(this.chatContent);
            this.Controls.Add(this.messageContent);
            this.Controls.Add(this.connect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button sendDirName;
        private System.Windows.Forms.Label directory_name;
        private System.Windows.Forms.TextBox directoryBox;
        private System.Windows.Forms.Label chatBox;
        private System.Windows.Forms.Label messageBox;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox chatContent;
        private System.Windows.Forms.TextBox messageContent;
        private System.Windows.Forms.Button connect;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button Open;
    }
}

