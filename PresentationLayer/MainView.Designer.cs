namespace PresentationLayer
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            this.notifPB = new System.Windows.Forms.PictureBox();
            this.profilePB = new System.Windows.Forms.PictureBox();
            this.menuPB = new System.Windows.Forms.PictureBox();
            this.homeBtn = new System.Windows.Forms.Button();
            this.petsBtn = new System.Windows.Forms.Button();
            this.underlineLbl = new System.Windows.Forms.Label();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.moreOptionsCS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.helpAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petsDetailTmr = new System.Windows.Forms.Timer(this.components);
            this.petsListDGV = new System.Windows.Forms.DataGridView();
            this.petOptionsCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.notifPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuPB)).BeginInit();
            this.moreOptionsCS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petsListDGV)).BeginInit();
            this.petOptionsCMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifPB
            // 
            this.notifPB.Image = global::PresentationLayer.Properties.Resources.notification;
            this.notifPB.Location = new System.Drawing.Point(198, 19);
            this.notifPB.Margin = new System.Windows.Forms.Padding(2);
            this.notifPB.Name = "notifPB";
            this.notifPB.Size = new System.Drawing.Size(33, 32);
            this.notifPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.notifPB.TabIndex = 0;
            this.notifPB.TabStop = false;
            // 
            // profilePB
            // 
            this.profilePB.Image = global::PresentationLayer.Properties.Resources.profile;
            this.profilePB.Location = new System.Drawing.Point(265, 19);
            this.profilePB.Margin = new System.Windows.Forms.Padding(2);
            this.profilePB.Name = "profilePB";
            this.profilePB.Size = new System.Drawing.Size(33, 32);
            this.profilePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePB.TabIndex = 1;
            this.profilePB.TabStop = false;
            // 
            // menuPB
            // 
            this.menuPB.Image = global::PresentationLayer.Properties.Resources.menu;
            this.menuPB.Location = new System.Drawing.Point(331, 19);
            this.menuPB.Margin = new System.Windows.Forms.Padding(2);
            this.menuPB.Name = "menuPB";
            this.menuPB.Size = new System.Drawing.Size(33, 32);
            this.menuPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuPB.TabIndex = 2;
            this.menuPB.TabStop = false;
            this.menuPB.Click += new System.EventHandler(this.menuPB_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Location = new System.Drawing.Point(73, 68);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(61, 23);
            this.homeBtn.TabIndex = 3;
            this.homeBtn.Text = "New Pet";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // petsBtn
            // 
            this.petsBtn.Location = new System.Drawing.Point(8, 68);
            this.petsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.petsBtn.Name = "petsBtn";
            this.petsBtn.Size = new System.Drawing.Size(61, 23);
            this.petsBtn.TabIndex = 4;
            this.petsBtn.Text = "Pets";
            this.petsBtn.UseVisualStyleBackColor = true;
            this.petsBtn.Click += new System.EventHandler(this.petsBtn_Click);
            // 
            // underlineLbl
            // 
            this.underlineLbl.AutoSize = true;
            this.underlineLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.underlineLbl.Location = new System.Drawing.Point(137, 72);
            this.underlineLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.underlineLbl.Name = "underlineLbl";
            this.underlineLbl.Size = new System.Drawing.Size(29, 13);
            this.underlineLbl.TabIndex = 5;
            this.underlineLbl.Text = "label";
            // 
            // optionsPanel
            // 
            this.optionsPanel.Location = new System.Drawing.Point(0, 0);
            this.optionsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(393, 65);
            this.optionsPanel.TabIndex = 6;
            // 
            // moreOptionsCS
            // 
            this.moreOptionsCS.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.moreOptionsCS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpAboutToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.moreOptionsCS.Name = "moreOptionsCS";
            this.moreOptionsCS.Size = new System.Drawing.Size(136, 70);
            // 
            // helpAboutToolStripMenuItem
            // 
            this.helpAboutToolStripMenuItem.Name = "helpAboutToolStripMenuItem";
            this.helpAboutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.helpAboutToolStripMenuItem.Text = "Help About";
            this.helpAboutToolStripMenuItem.Click += new System.EventHandler(this.helpAboutToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // petsListDGV
            // 
            this.petsListDGV.AllowUserToAddRows = false;
            this.petsListDGV.AllowUserToDeleteRows = false;
            this.petsListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.petsListDGV.Location = new System.Drawing.Point(0, 94);
            this.petsListDGV.Margin = new System.Windows.Forms.Padding(2);
            this.petsListDGV.Name = "petsListDGV";
            this.petsListDGV.ReadOnly = true;
            this.petsListDGV.RowHeadersWidth = 62;
            this.petsListDGV.RowTemplate.Height = 28;
            this.petsListDGV.Size = new System.Drawing.Size(393, 231);
            this.petsListDGV.TabIndex = 7;
            this.petsListDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.petsListDGV_CellClick);
            // 
            // petOptionsCMS
            // 
            this.petOptionsCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.petOptionsCMS.Name = "petOptionsCMS";
            this.petOptionsCMS.Size = new System.Drawing.Size(181, 70);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 317);
            this.Controls.Add(this.petsBtn);
            this.Controls.Add(this.petsListDGV);
            this.Controls.Add(this.underlineLbl);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.menuPB);
            this.Controls.Add(this.profilePB);
            this.Controls.Add(this.notifPB);
            this.Controls.Add(this.optionsPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MVP Demo";
            ((System.ComponentModel.ISupportInitialize)(this.notifPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuPB)).EndInit();
            this.moreOptionsCS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.petsListDGV)).EndInit();
            this.petOptionsCMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox notifPB;
        private System.Windows.Forms.PictureBox profilePB;
        private System.Windows.Forms.PictureBox menuPB;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button petsBtn;
        private System.Windows.Forms.Label underlineLbl;
        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.ContextMenuStrip moreOptionsCS;
        private System.Windows.Forms.ToolStripMenuItem helpAboutToolStripMenuItem;
        private System.Windows.Forms.Timer petsDetailTmr;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView petsListDGV;
        private System.Windows.Forms.ContextMenuStrip petOptionsCMS;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

