namespace TweetTap
{
    partial class TweetTap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TweetTap));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LocalPort = new System.Windows.Forms.TextBox();
            this.LocalIP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RemotePort = new System.Windows.Forms.TextBox();
            this.RemoteIP = new System.Windows.Forms.TextBox();
            this.SubmitIP_Port = new System.Windows.Forms.Button();
            this.ConversationBox = new System.Windows.Forms.ListBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.SendMessage = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.TweetTapLog = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TweetTapLog)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LocalPort);
            this.groupBox1.Controls.Add(this.LocalIP);
            this.groupBox1.Location = new System.Drawing.Point(101, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // LocalPort
            // 
            this.LocalPort.BackColor = System.Drawing.SystemColors.Info;
            this.LocalPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocalPort.Location = new System.Drawing.Point(100, 66);
            this.LocalPort.Name = "LocalPort";
            this.LocalPort.Size = new System.Drawing.Size(116, 20);
            this.LocalPort.TabIndex = 1;
            this.LocalPort.TextChanged += new System.EventHandler(this.PortUser1_TextChanged);
            // 
            // LocalIP
            // 
            this.LocalIP.BackColor = System.Drawing.SystemColors.Info;
            this.LocalIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocalIP.Location = new System.Drawing.Point(81, 21);
            this.LocalIP.Name = "LocalIP";
            this.LocalIP.Size = new System.Drawing.Size(136, 20);
            this.LocalIP.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.RemotePort);
            this.groupBox2.Controls.Add(this.RemoteIP);
            this.groupBox2.Location = new System.Drawing.Point(397, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 98);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "IP";
            // 
            // RemotePort
            // 
            this.RemotePort.BackColor = System.Drawing.SystemColors.Info;
            this.RemotePort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RemotePort.Location = new System.Drawing.Point(109, 59);
            this.RemotePort.Name = "RemotePort";
            this.RemotePort.Size = new System.Drawing.Size(128, 20);
            this.RemotePort.TabIndex = 1;
            // 
            // RemoteIP
            // 
            this.RemoteIP.BackColor = System.Drawing.SystemColors.Info;
            this.RemoteIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RemoteIP.Location = new System.Drawing.Point(87, 20);
            this.RemoteIP.Name = "RemoteIP";
            this.RemoteIP.Size = new System.Drawing.Size(151, 20);
            this.RemoteIP.TabIndex = 0;
            // 
            // SubmitIP_Port
            // 
            this.SubmitIP_Port.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SubmitIP_Port.Location = new System.Drawing.Point(683, 192);
            this.SubmitIP_Port.Name = "SubmitIP_Port";
            this.SubmitIP_Port.Size = new System.Drawing.Size(93, 31);
            this.SubmitIP_Port.TabIndex = 2;
            this.SubmitIP_Port.Text = "Submit";
            this.SubmitIP_Port.UseVisualStyleBackColor = true;
            this.SubmitIP_Port.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConversationBox
            // 
            this.ConversationBox.BackColor = System.Drawing.SystemColors.Info;
            this.ConversationBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConversationBox.FormattingEnabled = true;
            this.ConversationBox.Location = new System.Drawing.Point(100, 294);
            this.ConversationBox.Name = "ConversationBox";
            this.ConversationBox.Size = new System.Drawing.Size(559, 197);
            this.ConversationBox.TabIndex = 3;
            // 
            // textMessage
            // 
            this.textMessage.BackColor = System.Drawing.SystemColors.Info;
            this.textMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMessage.Location = new System.Drawing.Point(98, 511);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(561, 20);
            this.textMessage.TabIndex = 4;
            this.textMessage.TextChanged += new System.EventHandler(this.textMessage_TextChanged);
            // 
            // SendMessage
            // 
            this.SendMessage.Location = new System.Drawing.Point(683, 505);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(93, 26);
            this.SendMessage.TabIndex = 5;
            this.SendMessage.Text = "Send";
            this.SendMessage.UseVisualStyleBackColor = true;
            this.SendMessage.Click += new System.EventHandler(this.button2_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.CloseButton.Location = new System.Drawing.Point(763, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(37, 37);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.MinimizeButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 36);
            this.panel1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(338, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "TweetTap";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 32);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.MinimizeButton.Location = new System.Drawing.Point(727, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(37, 37);
            this.MinimizeButton.TabIndex = 7;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // TweetTapLog
            // 
            this.TweetTapLog.Image = ((System.Drawing.Image)(resources.GetObject("TweetTapLog.Image")));
            this.TweetTapLog.Location = new System.Drawing.Point(323, 55);
            this.TweetTapLog.Name = "TweetTapLog";
            this.TweetTapLog.Size = new System.Drawing.Size(89, 87);
            this.TweetTapLog.TabIndex = 8;
            this.TweetTapLog.TabStop = false;
            // 
            // TweetTap
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.TweetTapLog);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SendMessage);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.ConversationBox);
            this.Controls.Add(this.SubmitIP_Port);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "TweetTap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TweetTap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TweetTap_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TweetTap_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TweetTapLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LocalPort;
        private System.Windows.Forms.TextBox LocalIP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RemotePort;
        private System.Windows.Forms.TextBox RemoteIP;
        private System.Windows.Forms.Button SubmitIP_Port;
        private System.Windows.Forms.ListBox ConversationBox;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button SendMessage;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox TweetTapLog;
    }
}

