namespace Hromov_ContactBook
{
    partial class Create
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create));
            this.NamePic = new System.Windows.Forms.PictureBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NumberPic = new System.Windows.Forms.PictureBox();
            this.Number = new System.Windows.Forms.TextBox();
            this.CreateContact = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NamePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberPic)).BeginInit();
            this.SuspendLayout();
            // 
            // NamePic
            // 
            this.NamePic.Image = ((System.Drawing.Image)(resources.GetObject("NamePic.Image")));
            this.NamePic.Location = new System.Drawing.Point(110, 50);
            this.NamePic.Name = "NamePic";
            this.NamePic.Size = new System.Drawing.Size(120, 120);
            this.NamePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NamePic.TabIndex = 0;
            this.NamePic.TabStop = false;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.NameBox.Location = new System.Drawing.Point(275, 76);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.PlaceholderText = "Name";
            this.NameBox.Size = new System.Drawing.Size(300, 75);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumberPic
            // 
            this.NumberPic.Image = ((System.Drawing.Image)(resources.GetObject("NumberPic.Image")));
            this.NumberPic.Location = new System.Drawing.Point(105, 220);
            this.NumberPic.Name = "NumberPic";
            this.NumberPic.Size = new System.Drawing.Size(125, 150);
            this.NumberPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NumberPic.TabIndex = 2;
            this.NumberPic.TabStop = false;
            // 
            // Number
            // 
            this.Number.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Number.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Number.Location = new System.Drawing.Point(275, 256);
            this.Number.Multiline = true;
            this.Number.Name = "Number";
            this.Number.PlaceholderText = "Number";
            this.Number.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Number.Size = new System.Drawing.Size(300, 75);
            this.Number.TabIndex = 3;
            this.Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreateContact
            // 
            this.CreateContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(219)))), ((int)(((byte)(112)))));
            this.CreateContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(91)))));
            this.CreateContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(94)))));
            this.CreateContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateContact.Location = new System.Drawing.Point(310, 360);
            this.CreateContact.Name = "CreateContact";
            this.CreateContact.Size = new System.Drawing.Size(240, 70);
            this.CreateContact.TabIndex = 4;
            this.CreateContact.Text = "Create";
            this.CreateContact.UseVisualStyleBackColor = false;
            this.CreateContact.Click += new System.EventHandler(this.CreateContact_Click);
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Close.Location = new System.Drawing.Point(750, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(50, 50);
            this.Close.TabIndex = 5;
            this.Close.Text = "x";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.CreateContact);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.NumberPic);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NamePic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Create";
            this.Text = "Create";
            ((System.ComponentModel.ISupportInitialize)(this.NamePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox NamePic;
        private TextBox NameBox;
        private PictureBox NumberPic;
        private TextBox Number;
        private Button CreateContact;
        private Button Close;
    }
}