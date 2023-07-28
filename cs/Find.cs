using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hromov_ContactBook
{
    public partial class Find : Form
    {
        public Find()
        {
            InitializeComponent();
        }
        private void FindContact_Click(object sender, EventArgs e)
        {
            string contactName = this.contactName.Text;
            if (contactName != "")
            {
                string path = @"C:\ContactBook\" + contactName;
                if (Directory.Exists(path))
                {
                    Hide();
                    DataTransfer.contactName = contactName;
                    ContactInfo infoForm = new ContactInfo();
                    infoForm.Show();
                }
                else
                {
                    this.contactName.PlaceholderText = "Contact doesn't exist";
                    this.contactName.Text = "";
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string contactName = this.contactName.Text;
            if (contactName != "")
            {
                string path = @"C:\ContactBook\" + contactName;
                if (Directory.Exists(path))
                {
                    if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string logPath = @"C:\ContactBook\logs\" + contactName;
                        if (Directory.Exists(logPath))
                        {
                            Directory.Delete(logPath, recursive: true);
                            Directory.Move(path, logPath);
                        }
                        else
                        {
                            Directory.Move(path, logPath);
                        }
                        MessageBox.Show("Contact has been deleted");
                    }
                }
                else
                {
                    this.contactName.PlaceholderText = "Contact doesn't exist";
                    this.contactName.Text = "";
                }
            }
        }
        private void ChangeButton_Click(object sender, EventArgs e)
        {

            string contactName = this.contactName.Text;
            if (contactName != "")
            {
                string path = @"C:\ContactBook\" + contactName;
                if (Directory.Exists(path))
                {
                    Hide();
                    DataTransfer.contactName = contactName;
                    Change changeForm = new Change();
                    changeForm.Show();
                }
                else
                {
                    this.contactName.PlaceholderText = "Contact doesn't exist";
                    this.contactName.Text = "";
                }
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu menuForm = new MainMenu();
            menuForm.Show();
        }
    }
}