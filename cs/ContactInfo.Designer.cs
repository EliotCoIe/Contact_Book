namespace Hromov_ContactBook
{
    partial class ContactInfo
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
            this.ContactNameLabel = new System.Windows.Forms.Label();
            this.ContactNumberLabel = new System.Windows.Forms.Label();
            this.ContactSkypeLabel = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContactNameLabel
            // 
            this.ContactNameLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ContactNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ContactNameLabel.Location = new System.Drawing.Point(50, 25);
            this.ContactNameLabel.Name = "ContactNameLabel";
            this.ContactNameLabel.Size = new System.Drawing.Size(696, 200);
            this.ContactNameLabel.TabIndex = 0;
            this.ContactNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContactNumberLabel
            // 
            this.ContactNumberLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ContactNumberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ContactNumberLabel.Location = new System.Drawing.Point(50, 232);
            this.ContactNumberLabel.Name = "ContactNumberLabel";
            this.ContactNumberLabel.Size = new System.Drawing.Size(345, 175);
            this.ContactNumberLabel.TabIndex = 1;
            this.ContactNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContactSkypeLabel
            // 
            this.ContactSkypeLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ContactSkypeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ContactSkypeLabel.Location = new System.Drawing.Point(401, 232);
            this.ContactSkypeLabel.Name = "ContactSkypeLabel";
            this.ContactSkypeLabel.Size = new System.Drawing.Size(345, 175);
            this.ContactSkypeLabel.TabIndex = 2;
            this.ContactSkypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Close.Location = new System.Drawing.Point(752, -3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(50, 50);
            this.Close.TabIndex = 6;
            this.Close.Text = "x";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // ContactInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.ContactSkypeLabel);
            this.Controls.Add(this.ContactNumberLabel);
            this.Controls.Add(this.ContactNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContactInfo";
            this.Text = "ContactInfo";
            this.Load += new System.EventHandler(this.ContactInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label ContactNameLabel;
        private Label ContactNumberLabel;
        private Label ContactSkypeLabel;
        private Button Close;
    }
}