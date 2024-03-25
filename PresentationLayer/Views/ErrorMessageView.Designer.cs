namespace PresentationLayer.Views
{
    partial class ErrorMessageView
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
            this.messageTxtBox = new System.Windows.Forms.TextBox();
            this.copyBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageTxtBox
            // 
            this.messageTxtBox.Location = new System.Drawing.Point(12, 12);
            this.messageTxtBox.Multiline = true;
            this.messageTxtBox.Name = "messageTxtBox";
            this.messageTxtBox.Size = new System.Drawing.Size(516, 176);
            this.messageTxtBox.TabIndex = 0;
            // 
            // copyBtn
            // 
            this.copyBtn.Location = new System.Drawing.Point(312, 207);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(103, 29);
            this.copyBtn.TabIndex = 1;
            this.copyBtn.Text = "Copy";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(431, 207);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(97, 29);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // ErrorMessageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 248);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.messageTxtBox);
            this.Name = "ErrorMessageView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageTxtBox;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}