namespace NAudioLibrary
{
    partial class NetworkChatPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxInputDevices = new System.Windows.Forms.ComboBox();
            this.comboBoxCodecs = new System.Windows.Forms.ComboBox();
            this.buttonStartConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxProtocol = new System.Windows.Forms.ComboBox();
            this.textBoxIPAddressS = new System.Windows.Forms.TextBox();
            this.textBoxPortS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonStartStreamingLong = new System.Windows.Forms.Button();
            this.lblSentData = new System.Windows.Forms.Label();
            this.lblReceivedData = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxInputDevices
            // 
            this.comboBoxInputDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInputDevices.FormattingEnabled = true;
            this.comboBoxInputDevices.Location = new System.Drawing.Point(81, 169);
            this.comboBoxInputDevices.Name = "comboBoxInputDevices";
            this.comboBoxInputDevices.Size = new System.Drawing.Size(424, 21);
            this.comboBoxInputDevices.TabIndex = 2;
            // 
            // comboBoxCodecs
            // 
            this.comboBoxCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCodecs.FormattingEnabled = true;
            this.comboBoxCodecs.Location = new System.Drawing.Point(81, 196);
            this.comboBoxCodecs.Name = "comboBoxCodecs";
            this.comboBoxCodecs.Size = new System.Drawing.Size(424, 21);
            this.comboBoxCodecs.TabIndex = 3;
            // 
            // buttonStartConnect
            // 
            this.buttonStartConnect.Location = new System.Drawing.Point(81, 251);
            this.buttonStartConnect.Name = "buttonStartConnect";
            this.buttonStartConnect.Size = new System.Drawing.Size(160, 23);
            this.buttonStartConnect.TabIndex = 4;
            this.buttonStartConnect.Text = "Connect";
            this.buttonStartConnect.UseVisualStyleBackColor = true;
            this.buttonStartConnect.Click += new System.EventHandler(this.buttonStartConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Server IP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Input Device:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Compression";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Protocol";
            // 
            // comboBoxProtocol
            // 
            this.comboBoxProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProtocol.FormattingEnabled = true;
            this.comboBoxProtocol.Location = new System.Drawing.Point(81, 224);
            this.comboBoxProtocol.Name = "comboBoxProtocol";
            this.comboBoxProtocol.Size = new System.Drawing.Size(424, 21);
            this.comboBoxProtocol.TabIndex = 9;
            // 
            // textBoxIPAddressS
            // 
            this.textBoxIPAddressS.Location = new System.Drawing.Point(81, 112);
            this.textBoxIPAddressS.Name = "textBoxIPAddressS";
            this.textBoxIPAddressS.Size = new System.Drawing.Size(157, 20);
            this.textBoxIPAddressS.TabIndex = 0;
            this.textBoxIPAddressS.Text = "197.81.192.173";
            // 
            // textBoxPortS
            // 
            this.textBoxPortS.Location = new System.Drawing.Point(81, 139);
            this.textBoxPortS.Name = "textBoxPortS";
            this.textBoxPortS.Size = new System.Drawing.Size(157, 20);
            this.textBoxPortS.TabIndex = 1;
            this.textBoxPortS.Text = "3030";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Port Send";
            // 
            // buttonStartStreamingLong
            // 
            this.buttonStartStreamingLong.Enabled = false;
            this.buttonStartStreamingLong.Location = new System.Drawing.Point(247, 251);
            this.buttonStartStreamingLong.Name = "buttonStartStreamingLong";
            this.buttonStartStreamingLong.Size = new System.Drawing.Size(258, 23);
            this.buttonStartStreamingLong.TabIndex = 11;
            this.buttonStartStreamingLong.Text = "Turn Mic On";
            this.buttonStartStreamingLong.UseVisualStyleBackColor = true;
            this.buttonStartStreamingLong.Click += new System.EventHandler(this.buttonStartStreamingLong_Click);
            // 
            // lblSentData
            // 
            this.lblSentData.AutoSize = true;
            this.lblSentData.Location = new System.Drawing.Point(306, 142);
            this.lblSentData.Name = "lblSentData";
            this.lblSentData.Size = new System.Drawing.Size(13, 13);
            this.lblSentData.TabIndex = 12;
            this.lblSentData.Text = "0";
            // 
            // lblReceivedData
            // 
            this.lblReceivedData.AutoSize = true;
            this.lblReceivedData.Location = new System.Drawing.Point(306, 115);
            this.lblReceivedData.Name = "lblReceivedData";
            this.lblReceivedData.Size = new System.Drawing.Size(13, 13);
            this.lblReceivedData.TabIndex = 12;
            this.lblReceivedData.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Received:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Sent:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Port Send";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Server IP:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(81, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "12303";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(81, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "197.81.192.173";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(247, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(258, 20);
            this.textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(247, 29);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(258, 50);
            this.textBox4.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(81, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // NetworkChatPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblReceivedData);
            this.Controls.Add(this.lblSentData);
            this.Controls.Add(this.buttonStartStreamingLong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxProtocol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStartConnect);
            this.Controls.Add(this.comboBoxCodecs);
            this.Controls.Add(this.comboBoxInputDevices);
            this.Controls.Add(this.textBoxPortS);
            this.Controls.Add(this.textBoxIPAddressS);
            this.Name = "NetworkChatPanel";
            this.Size = new System.Drawing.Size(514, 284);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxInputDevices;
        private System.Windows.Forms.ComboBox comboBoxCodecs;
        private System.Windows.Forms.Button buttonStartConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxProtocol;
        private System.Windows.Forms.TextBox textBoxIPAddressS;
        private System.Windows.Forms.TextBox textBoxPortS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonStartStreamingLong;
        private System.Windows.Forms.Label lblSentData;
        private System.Windows.Forms.Label lblReceivedData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
    }
}
