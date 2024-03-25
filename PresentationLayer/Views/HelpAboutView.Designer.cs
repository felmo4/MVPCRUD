namespace PresentationLayer.Views
{
    partial class HelpAboutView
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productLbl = new System.Windows.Forms.Label();
            this.versionLbl = new System.Windows.Forms.Label();
            this.copyrightLbl = new System.Windows.Forms.Label();
            this.CompanyLbl = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentationLayer.Properties.Resources.dog;
            this.pictureBox1.Location = new System.Drawing.Point(1, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // productLbl
            // 
            this.productLbl.Location = new System.Drawing.Point(294, 143);
            this.productLbl.Name = "productLbl";
            this.productLbl.Size = new System.Drawing.Size(237, 23);
            this.productLbl.TabIndex = 1;
            this.productLbl.Text = "Product";
            // 
            // versionLbl
            // 
            this.versionLbl.Location = new System.Drawing.Point(294, 167);
            this.versionLbl.Name = "versionLbl";
            this.versionLbl.Size = new System.Drawing.Size(237, 23);
            this.versionLbl.TabIndex = 2;
            this.versionLbl.Text = "Version";
            // 
            // copyrightLbl
            // 
            this.copyrightLbl.Location = new System.Drawing.Point(294, 191);
            this.copyrightLbl.Name = "copyrightLbl";
            this.copyrightLbl.Size = new System.Drawing.Size(237, 23);
            this.copyrightLbl.TabIndex = 3;
            this.copyrightLbl.Text = "Copyright";
            // 
            // CompanyLbl
            // 
            this.CompanyLbl.Location = new System.Drawing.Point(294, 215);
            this.CompanyLbl.Name = "CompanyLbl";
            this.CompanyLbl.Size = new System.Drawing.Size(237, 23);
            this.CompanyLbl.TabIndex = 4;
            this.CompanyLbl.Text = "Company";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.Location = new System.Drawing.Point(294, 239);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(237, 110);
            this.descriptionLbl.TabIndex = 5;
            this.descriptionLbl.Text = "Description";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(226, 379);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(104, 33);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // HelpAboutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.CompanyLbl);
            this.Controls.Add(this.copyrightLbl);
            this.Controls.Add(this.versionLbl);
            this.Controls.Add(this.productLbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HelpAboutView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelpAboutView";
            this.Load += new System.EventHandler(this.HelpAboutView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label productLbl;
        private System.Windows.Forms.Label versionLbl;
        private System.Windows.Forms.Label copyrightLbl;
        private System.Windows.Forms.Label CompanyLbl;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.Button closeBtn;
    }
}