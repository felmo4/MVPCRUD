namespace PresentationLayer.Views
{
    partial class PetsDetailView
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
            this.petIDTxtB = new System.Windows.Forms.TextBox();
            this.petnameTxtB = new System.Windows.Forms.TextBox();
            this.petbreedTxtB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.petbdayDTPicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // petIDTxtB
            // 
            this.petIDTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petIDTxtB.Location = new System.Drawing.Point(87, 53);
            this.petIDTxtB.Margin = new System.Windows.Forms.Padding(2);
            this.petIDTxtB.Name = "petIDTxtB";
            this.petIDTxtB.ReadOnly = true;
            this.petIDTxtB.Size = new System.Drawing.Size(215, 26);
            this.petIDTxtB.TabIndex = 0;
            // 
            // petnameTxtB
            // 
            this.petnameTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petnameTxtB.Location = new System.Drawing.Point(87, 99);
            this.petnameTxtB.Margin = new System.Windows.Forms.Padding(2);
            this.petnameTxtB.Name = "petnameTxtB";
            this.petnameTxtB.Size = new System.Drawing.Size(215, 26);
            this.petnameTxtB.TabIndex = 1;
            // 
            // petbreedTxtB
            // 
            this.petbreedTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petbreedTxtB.Location = new System.Drawing.Point(87, 146);
            this.petbreedTxtB.Margin = new System.Windows.Forms.Padding(2);
            this.petbreedTxtB.Name = "petbreedTxtB";
            this.petbreedTxtB.Size = new System.Drawing.Size(215, 26);
            this.petbreedTxtB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Breed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Birthday";
            // 
            // petbdayDTPicker
            // 
            this.petbdayDTPicker.CustomFormat = "yyyy-MM-dd";
            this.petbdayDTPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petbdayDTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.petbdayDTPicker.Location = new System.Drawing.Point(87, 193);
            this.petbdayDTPicker.Margin = new System.Windows.Forms.Padding(2);
            this.petbdayDTPicker.Name = "petbdayDTPicker";
            this.petbdayDTPicker.Size = new System.Drawing.Size(215, 26);
            this.petbdayDTPicker.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 240);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(213, 240);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(88, 34);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Save";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // PetsDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 317);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.petbdayDTPicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.petbreedTxtB);
            this.Controls.Add(this.petnameTxtB);
            this.Controls.Add(this.petIDTxtB);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PetsDetailView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PetsDetailView";
            this.Load += new System.EventHandler(this.PetsDetailView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox petIDTxtB;
        private System.Windows.Forms.TextBox petnameTxtB;
        private System.Windows.Forms.TextBox petbreedTxtB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker petbdayDTPicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addBtn;
    }
}