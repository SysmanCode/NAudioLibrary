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
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.comboBoxInputDevices = new System.Windows.Forms.ComboBox();
            this.comboBoxCodecs = new System.Windows.Forms.ComboBox();
            this.buttonStartConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxProtocol = new System.Windows.Forms.ComboBox();
            this.textBoxIPAddressS = new System.Windows.Forms.TextBox();
            this.textBoxPortS = new System.Windows.Forms.TextBox();
            this.buttonStartStreaming = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(80, 29);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(157, 20);
            this.textBoxPort.TabIndex = 1;
            this.textBoxPort.Text = "5001";
            // 
            // comboBoxInputDevices
            // 
            this.comboBoxInputDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInputDevices.FormattingEnabled = true;
            this.comboBoxInputDevices.Location = new System.Drawing.Point(80, 59);
            this.comboBoxInputDevices.Name = "comboBoxInputDevices";
            this.comboBoxInputDevices.Size = new System.Drawing.Size(424, 21);
            this.comboBoxInputDevices.TabIndex = 2;
            // 
            // comboBoxCodecs
            // 
            this.comboBoxCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCodecs.FormattingEnabled = true;
            this.comboBoxCodecs.Location = new System.Drawing.Point(80, 86);
            this.comboBoxCodecs.Name = "comboBoxCodecs";
            this.comboBoxCodecs.Size = new System.Drawing.Size(424, 21);
            this.comboBoxCodecs.TabIndex = 3;
            // 
            // buttonStartConnect
            // 
            this.buttonStartConnect.Location = new System.Drawing.Point(240, 168);
            this.buttonStartConnect.Name = "buttonStartConnect";
            this.buttonStartConnect.Size = new System.Drawing.Size(129, 23);
            this.buttonStartConnect.TabIndex = 4;
            this.buttonStartConnect.Text = "Connect";
            this.buttonStartConnect.UseVisualStyleBackColor = true;
            this.buttonStartConnect.Click += new System.EventHandler(this.buttonStartConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Input Device:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Compression";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Protocol";
            // 
            // comboBoxProtocol
            // 
            this.comboBoxProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProtocol.FormattingEnabled = true;
            this.comboBoxProtocol.Location = new System.Drawing.Point(80, 114);
            this.comboBoxProtocol.Name = "comboBoxProtocol";
            this.comboBoxProtocol.Size = new System.Drawing.Size(424, 21);
            this.comboBoxProtocol.TabIndex = 9;
            // 
            // textBoxIPAddressS
            // 
            this.textBoxIPAddressS.Location = new System.Drawing.Point(80, 2);
            this.textBoxIPAddressS.Name = "textBoxIPAddressS";
            this.textBoxIPAddressS.Size = new System.Drawing.Size(157, 20);
            this.textBoxIPAddressS.TabIndex = 0;
            this.textBoxIPAddressS.Text = "192.168.8.1";
            // 
            // textBoxPortS
            // 
            this.textBoxPortS.Location = new System.Drawing.Point(347, 29);
            this.textBoxPortS.Name = "textBoxPortS";
            this.textBoxPortS.Size = new System.Drawing.Size(157, 20);
            this.textBoxPortS.TabIndex = 1;
            this.textBoxPortS.Text = "2011";
            // 
            // buttonStartStreaming
            // 
            this.buttonStartStreaming.Location = new System.Drawing.Point(375, 168);
            this.buttonStartStreaming.Name = "buttonStartStreaming";
            this.buttonStartStreaming.Size = new System.Drawing.Size(129, 23);
            this.buttonStartStreaming.TabIndex = 4;
            this.buttonStartStreaming.Text = "Talk";
            this.buttonStartStreaming.UseVisualStyleBackColor = true;
            this.buttonStartStreaming.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonStartStreaming_MouseDown);
            this.buttonStartStreaming.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonStartStreaming_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Port Send";
            // 
            // NetworkChatPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxProtocol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStartStreaming);
            this.Controls.Add(this.buttonStartConnect);
            this.Controls.Add(this.comboBoxCodecs);
            this.Controls.Add(this.comboBoxInputDevices);
            this.Controls.Add(this.textBoxPortS);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxIPAddressS);
            this.Name = "NetworkChatPanel";
            this.Size = new System.Drawing.Size(593, 228);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.ComboBox comboBoxInputDevices;
        private System.Windows.Forms.ComboBox comboBoxCodecs;
        private System.Windows.Forms.Button buttonStartConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxProtocol;
        private System.Windows.Forms.TextBox textBoxIPAddressS;
        private System.Windows.Forms.TextBox textBoxPortS;
        private System.Windows.Forms.Button buttonStartStreaming;
        private System.Windows.Forms.Label label7;
    }
}
