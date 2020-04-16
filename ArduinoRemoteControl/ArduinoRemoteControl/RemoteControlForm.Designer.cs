namespace ArduinoRemoteControl
{
    partial class RemoteControlForm
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
            this.groupBoxConnection = new System.Windows.Forms.GroupBox();
            this.labelConnected = new System.Windows.Forms.Label();
            this.disconnecButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.listBoxMessagesReceived = new System.Windows.Forms.ListBox();
            this.textBoxSendMessage = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.groupBoxMessageReceive = new System.Windows.Forms.GroupBox();
            this.groupBoxMessageSend = new System.Windows.Forms.GroupBox();
            this.groupBoxConnection.SuspendLayout();
            this.groupBoxMessageReceive.SuspendLayout();
            this.groupBoxMessageSend.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConnection
            // 
            this.groupBoxConnection.Controls.Add(this.labelConnected);
            this.groupBoxConnection.Controls.Add(this.disconnecButton);
            this.groupBoxConnection.Controls.Add(this.connectButton);
            this.groupBoxConnection.Location = new System.Drawing.Point(14, 21);
            this.groupBoxConnection.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxConnection.Name = "groupBoxConnection";
            this.groupBoxConnection.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxConnection.Size = new System.Drawing.Size(506, 119);
            this.groupBoxConnection.TabIndex = 5;
            this.groupBoxConnection.TabStop = false;
            this.groupBoxConnection.Text = "Connection";
            // 
            // labelConnected
            // 
            this.labelConnected.BackColor = System.Drawing.Color.Red;
            this.labelConnected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelConnected.Location = new System.Drawing.Point(285, 24);
            this.labelConnected.Name = "labelConnected";
            this.labelConnected.Size = new System.Drawing.Size(150, 63);
            this.labelConnected.TabIndex = 3;
            this.labelConnected.Text = "not connected";
            this.labelConnected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // disconnecButton
            // 
            this.disconnecButton.Location = new System.Drawing.Point(11, 72);
            this.disconnecButton.Margin = new System.Windows.Forms.Padding(2);
            this.disconnecButton.Name = "disconnecButton";
            this.disconnecButton.Size = new System.Drawing.Size(79, 28);
            this.disconnecButton.TabIndex = 2;
            this.disconnecButton.Text = "Disconnect";
            this.disconnecButton.UseVisualStyleBackColor = true;
            this.disconnecButton.Click += new System.EventHandler(this.disconnecButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(11, 24);
            this.connectButton.Margin = new System.Windows.Forms.Padding(2);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(79, 28);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // listBoxMessagesReceived
            // 
            this.listBoxMessagesReceived.FormattingEnabled = true;
            this.listBoxMessagesReceived.Location = new System.Drawing.Point(23, 19);
            this.listBoxMessagesReceived.Name = "listBoxMessagesReceived";
            this.listBoxMessagesReceived.Size = new System.Drawing.Size(212, 95);
            this.listBoxMessagesReceived.TabIndex = 0;
            // 
            // textBoxSendMessage
            // 
            this.textBoxSendMessage.Location = new System.Drawing.Point(21, 132);
            this.textBoxSendMessage.Name = "textBoxSendMessage";
            this.textBoxSendMessage.Size = new System.Drawing.Size(201, 20);
            this.textBoxSendMessage.TabIndex = 6;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(98, 158);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(83, 158);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 8;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // groupBoxMessageReceive
            // 
            this.groupBoxMessageReceive.Controls.Add(this.textBoxSendMessage);
            this.groupBoxMessageReceive.Controls.Add(this.buttonSend);
            this.groupBoxMessageReceive.Location = new System.Drawing.Point(14, 171);
            this.groupBoxMessageReceive.Name = "groupBoxMessageReceive";
            this.groupBoxMessageReceive.Size = new System.Drawing.Size(241, 187);
            this.groupBoxMessageReceive.TabIndex = 9;
            this.groupBoxMessageReceive.TabStop = false;
            this.groupBoxMessageReceive.Text = "Message send";
            // 
            // groupBoxMessageSend
            // 
            this.groupBoxMessageSend.Controls.Add(this.listBoxMessagesReceived);
            this.groupBoxMessageSend.Controls.Add(this.buttonClear);
            this.groupBoxMessageSend.Location = new System.Drawing.Point(276, 171);
            this.groupBoxMessageSend.Name = "groupBoxMessageSend";
            this.groupBoxMessageSend.Size = new System.Drawing.Size(241, 187);
            this.groupBoxMessageSend.TabIndex = 10;
            this.groupBoxMessageSend.TabStop = false;
            this.groupBoxMessageSend.Text = "Message receive";
            // 
            // RemoteControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 375);
            this.Controls.Add(this.groupBoxMessageSend);
            this.Controls.Add(this.groupBoxMessageReceive);
            this.Controls.Add(this.groupBoxConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RemoteControlForm";
            this.Text = "Arduino Remote Control";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RemoteControlForm_FormClosed);
            this.groupBoxConnection.ResumeLayout(false);
            this.groupBoxMessageReceive.ResumeLayout(false);
            this.groupBoxMessageReceive.PerformLayout();
            this.groupBoxMessageSend.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxConnection;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnecButton;
        private System.Windows.Forms.ListBox listBoxMessagesReceived;
        private System.Windows.Forms.TextBox textBoxSendMessage;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.GroupBox groupBoxMessageReceive;
        private System.Windows.Forms.GroupBox groupBoxMessageSend;
        private System.Windows.Forms.Label labelConnected;
    }
}

