namespace Hromov_ContactBook
{
    partial class Change
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
            this.SkypeSettingsButton = new System.Windows.Forms.Button();
            this.ChangeNameButton = new System.Windows.Forms.Button();
            this.ChangeNumberButton = new System.Windows.Forms.Button();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.NumberInput = new System.Windows.Forms.TextBox();
            this.SkypeInput = new System.Windows.Forms.TextBox();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SkypeSettingsButton
            // 
            this.SkypeSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(219)))), ((int)(((byte)(112)))));
            this.SkypeSettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(91)))));
            this.SkypeSettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(94)))));
            this.SkypeSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SkypeSettingsButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SkypeSettingsButton.Location = new System.Drawing.Point(393, 311);
            this.SkypeSettingsButton.Name = "SkypeSettingsButton";
            this.SkypeSettingsButton.Size = new System.Drawing.Size(297, 93);
            this.SkypeSettingsButton.TabIndex = 5;
            this.SkypeSettingsButton.Text = "Change/Add Skype";
            this.SkypeSettingsButton.UseVisualStyleBackColor = false;
            this.SkypeSettingsButton.Click += new System.EventHandler(this.SkypeSettingsButton_Click);
            // 
            // ChangeNameButton
            // 
            this.ChangeNameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(219)))), ((int)(((byte)(112)))));
            this.ChangeNameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(91)))));
            this.ChangeNameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(94)))));
            this.ChangeNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeNameButton.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChangeNameButton.Location = new System.Drawing.Point(90, 113);
            this.ChangeNameButton.Name = "ChangeNameButton";
            this.ChangeNameButton.Size = new System.Drawing.Size(600, 122);
            this.ChangeNameButton.TabIndex = 6;
            this.ChangeNameButton.Text = "Change name";
            this.ChangeNameButton.UseVisualStyleBackColor = false;
            this.ChangeNameButton.Click += new System.EventHandler(this.ChangeNameButton_Click);
            // 
            // ChangeNumberButton
            // 
            this.ChangeNumberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(219)))), ((int)(((byte)(112)))));
            this.ChangeNumberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(91)))));
            this.ChangeNumberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(235)))), ((int)(((byte)(94)))));
            this.ChangeNumberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeNumberButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChangeNumberButton.Location = new System.Drawing.Point(90, 311);
            this.ChangeNumberButton.Name = "ChangeNumberButton";
            this.ChangeNumberButton.Size = new System.Drawing.Size(297, 93);
            this.ChangeNumberButton.TabIndex = 7;
            this.ChangeNumberButton.Text = "Change Number";
            this.ChangeNumberButton.UseVisualStyleBackColor = false;
            this.ChangeNumberButton.Click += new System.EventHandler(this.ChangeNumberButton_Click);
            // 
            // NameInput
            // 
            this.NameInput.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameInput.Location = new System.Drawing.Point(90, 44);
            this.NameInput.Multiline = true;
            this.NameInput.Name = "NameInput";
            this.NameInput.PlaceholderText = "Enter new name";
            this.NameInput.Size = new System.Drawing.Size(600, 63);
            this.NameInput.TabIndex = 8;
            this.NameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumberInput
            // 
            this.NumberInput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumberInput.Location = new System.Drawing.Point(90, 241);
            this.NumberInput.Multiline = true;
            this.NumberInput.Name = "NumberInput";
            this.NumberInput.PlaceholderText = "Enter new number";
            this.NumberInput.Size = new System.Drawing.Size(297, 64);
            this.NumberInput.TabIndex = 9;
            this.NumberInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SkypeInput
            // 
            this.SkypeInput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SkypeInput.Location = new System.Drawing.Point(393, 241);
            this.SkypeInput.Multiline = true;
            this.SkypeInput.Name = "SkypeInput";
            this.SkypeInput.PlaceholderText = "Enter new Skype";
            this.SkypeInput.Size = new System.Drawing.Size(297, 64);
            this.SkypeInput.TabIndex = 10;
            this.SkypeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Close.Location = new System.Drawing.Point(751, -1);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(50, 50);
            this.Close.TabIndex = 11;
            this.Close.Text = "x";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.SkypeInput);
            this.Controls.Add(this.NumberInput);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.ChangeNumberButton);
            this.Controls.Add(this.ChangeNameButton);
            this.Controls.Add(this.SkypeSettingsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Change";
            this.Text = "Change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SkypeSettingsButton;
        private Button ChangeNameButton;
        private Button ChangeNumberButton;
        private TextBox NameInput;
        private TextBox NumberInput;
        private TextBox SkypeInput;
        private Button Close;
    }
}