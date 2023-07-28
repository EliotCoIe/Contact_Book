namespace Hromov_ContactBook
{
    partial class MainMenu
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
            this.Create = new System.Windows.Forms.Button();
            this.ContactSettingsButton = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Create.Location = new System.Drawing.Point(34, 30);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(510, 390);
            this.Create.TabIndex = 0;
            this.Create.Text = "Create Contact";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // ContactSettingsButton
            // 
            this.ContactSettingsButton.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ContactSettingsButton.Location = new System.Drawing.Point(550, 30);
            this.ContactSettingsButton.Name = "ContactSettingsButton";
            this.ContactSettingsButton.Size = new System.Drawing.Size(220, 390);
            this.ContactSettingsButton.TabIndex = 1;
            this.ContactSettingsButton.Text = "Contact settings";
            this.ContactSettingsButton.UseVisualStyleBackColor = true;
            this.ContactSettingsButton.Click += new System.EventHandler(this.ContactSettingsButton_Click);
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Close.Location = new System.Drawing.Point(769, -10);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(32, 41);
            this.Close.TabIndex = 9;
            this.Close.Text = "x";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.ContactSettingsButton);
            this.Controls.Add(this.Create);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Create;
        private Button ContactSettingsButton;
        private Button Close;
    }
}