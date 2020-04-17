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
            this.groupBoxMessageSend = new System.Windows.Forms.GroupBox();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.groupBoxMessageSend.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMessageSend
            // 
            this.groupBoxMessageSend.Controls.Add(this.listBoxHistory);
            this.groupBoxMessageSend.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMessageSend.Name = "groupBoxMessageSend";
            this.groupBoxMessageSend.Size = new System.Drawing.Size(507, 338);
            this.groupBoxMessageSend.TabIndex = 10;
            this.groupBoxMessageSend.TabStop = false;
            this.groupBoxMessageSend.Text = "History";
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.Location = new System.Drawing.Point(23, 19);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(478, 303);
            this.listBoxHistory.TabIndex = 0;
            // 
            // RemoteControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 375);
            this.Controls.Add(this.groupBoxMessageSend);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RemoteControlForm";
            this.Text = "Move-IT-Monitor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RemoteControlForm_FormClosed);
            this.Load += new System.EventHandler(this.RemoteControlForm_Load);
            this.groupBoxMessageSend.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMessageSend;
        private System.Windows.Forms.ListBox listBoxHistory;
    }
}

