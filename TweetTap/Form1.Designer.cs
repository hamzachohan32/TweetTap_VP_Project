namespace TweetTap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.textLocalIP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textRemotePort = new System.Windows.Forms.TextBox();
            this.textRemoteIP = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.Conversation = new System.Windows.Forms.ListBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textLocalPort);
            this.groupBox1.Controls.Add(this.textLocalIP);
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
            // textLocalPort
            // 
            this.textLocalPort.BackColor = System.Drawing.SystemColors.Info;
            this.textLocalPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textLocalPort.Location = new System.Drawing.Point(100, 66);
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new System.Drawing.Size(116, 20);
            this.textLocalPort.TabIndex = 1;
            this.textLocalPort.TextChanged += new System.EventHandler(this.PortUser1_TextChanged);
            // 
            // textLocalIP
            // 
            this.textLocalIP.BackColor = System.Drawing.SystemColors.Info;
            this.textLocalIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textLocalIP.Location = new System.Drawing.Point(81, 21);
            this.textLocalIP.Name = "textLocalIP";
            this.textLocalIP.Size = new System.Drawing.Size(136, 20);
            this.textLocalIP.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textRemotePort);
            this.groupBox2.Controls.Add(this.textRemoteIP);
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
            // textRemotePort
            // 
            this.textRemotePort.BackColor = System.Drawing.SystemColors.Info;
            this.textRemotePort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textRemotePort.Location = new System.Drawing.Point(109, 59);
            this.textRemotePort.Name = "textRemotePort";
            this.textRemotePort.Size = new System.Drawing.Size(128, 20);
            this.textRemotePort.TabIndex = 1;
            // 
            // textRemoteIP
            // 
            this.textRemoteIP.BackColor = System.Drawing.SystemColors.Info;
            this.textRemoteIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textRemoteIP.Location = new System.Drawing.Point(87, 20);
            this.textRemoteIP.Name = "textRemoteIP";
            this.textRemoteIP.Size = new System.Drawing.Size(151, 20);
            this.textRemoteIP.TabIndex = 0;
            // 
            // buttonConnect
            // 
            this.buttonConnect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonConnect.Location = new System.Drawing.Point(683, 192);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(93, 31);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Submit";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // Conversation
            // 
            this.Conversation.BackColor = System.Drawing.SystemColors.Info;
            this.Conversation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Conversation.FormattingEnabled = true;
            this.Conversation.Location = new System.Drawing.Point(100, 294);
            this.Conversation.Name = "Conversation";
            this.Conversation.Size = new System.Drawing.Size(559, 197);
            this.Conversation.TabIndex = 3;
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
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(683, 505);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(93, 26);
            this.Send.TabIndex = 5;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.button2_Click);
            // 
            // Close
            // 
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Close.Location = new System.Drawing.Point(763, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(37, 37);
            this.Close.TabIndex = 6;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Close);
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
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.Location = new System.Drawing.Point(727, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 37);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(323, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 87);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.Conversation);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "TweetTap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textLocalPort;
        private System.Windows.Forms.TextBox textLocalIP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textRemotePort;
        private System.Windows.Forms.TextBox textRemoteIP;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ListBox Conversation;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

