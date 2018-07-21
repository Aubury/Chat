namespace Chat_Client
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.label_IP = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.sineINbutton = new System.Windows.Forms.Button();
            this.sineOUTbutton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.send_button = new System.Windows.Forms.Button();
            this.labelSmile = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chatTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(412, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(260, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(409, 22);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name:";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(412, 126);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(66, 13);
            this.labelColor.TabIndex = 3;
            this.labelColor.Text = "Color of text:";
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(412, 142);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(260, 20);
            this.colorTextBox.TabIndex = 4;
            this.colorTextBox.Click += new System.EventHandler(this.colorTextBox_TextChanged);
            // 
            // label_IP
            // 
            this.label_IP.AutoSize = true;
            this.label_IP.Location = new System.Drawing.Point(409, 72);
            this.label_IP.Name = "label_IP";
            this.label_IP.Size = new System.Drawing.Size(60, 13);
            this.label_IP.TabIndex = 5;
            this.label_IP.Text = "IP address:";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(412, 88);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(260, 20);
            this.ipTextBox.TabIndex = 6;
            // 
            // sineINbutton
            // 
            this.sineINbutton.Location = new System.Drawing.Point(557, 253);
            this.sineINbutton.Name = "sineINbutton";
            this.sineINbutton.Size = new System.Drawing.Size(112, 30);
            this.sineINbutton.TabIndex = 7;
            this.sineINbutton.Text = "Sine in";
            this.sineINbutton.UseVisualStyleBackColor = true;
            this.sineINbutton.Click += new System.EventHandler(this.sineINbutton_Click);
            // 
            // sineOUTbutton
            // 
            this.sineOUTbutton.Location = new System.Drawing.Point(557, 289);
            this.sineOUTbutton.Name = "sineOUTbutton";
            this.sineOUTbutton.Size = new System.Drawing.Size(112, 30);
            this.sineOUTbutton.TabIndex = 8;
            this.sineOUTbutton.Text = "Sine out ";
            this.sineOUTbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sineOUTbutton.UseVisualStyleBackColor = true;
            this.sineOUTbutton.Click += new System.EventHandler(this.sineOUTbutton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(32, 253);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(354, 60);
            this.messageTextBox.TabIndex = 9;
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(412, 253);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(112, 66);
            this.send_button.TabIndex = 10;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // labelSmile
            // 
            this.labelSmile.AutoSize = true;
            this.labelSmile.Location = new System.Drawing.Point(412, 165);
            this.labelSmile.Name = "labelSmile";
            this.labelSmile.Size = new System.Drawing.Size(46, 13);
            this.labelSmile.TabIndex = 11;
            this.labelSmile.Text = "Avatars:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Chat_Client.Properties.Resources._6;
            this.pictureBox1.Location = new System.Drawing.Point(474, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // chatTextBox
            // 
            this.chatTextBox.Location = new System.Drawing.Point(32, 22);
            this.chatTextBox.Name = "chatTextBox";
            this.chatTextBox.Size = new System.Drawing.Size(354, 210);
            this.chatTextBox.TabIndex = 13;
            this.chatTextBox.Text = "";
            this.chatTextBox.TextChanged += new System.EventHandler(this.chatTextBox_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 331);
            this.Controls.Add(this.chatTextBox);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelSmile);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.sineOUTbutton);
            this.Controls.Add(this.sineINbutton);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.label_IP);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.nameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.Label label_IP;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Button sineINbutton;
        private System.Windows.Forms.Button sineOUTbutton;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Label labelSmile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox chatTextBox;
    }
}

