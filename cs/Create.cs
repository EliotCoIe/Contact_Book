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
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private void CreateContact_Click(object sender, EventArgs e)
        {
            string contactName = NameBox.Text;
            string contactNumber = Number.Text;
            string path = @"C:\ContactBook\" + contactName;
            string numberPath = path + "/number.txt";
            try
            {
                if (contactName != "") 
                {
                    if (!Directory.Exists(path))
                    {
                        DirectoryInfo contact = Directory.CreateDirectory(path);
                        MessageBox.Show("Contact created!");
                    }
                    if (File.Exists(numberPath))
                    {
                        Number.Text = "";
                        Number.Font = new Font("Segoe UI Semibold", 10);
                        Number.PlaceholderText = "Number already exists";
                    }
                    else
                    {
                        if (contactNumber != "")
                        {
                            File.WriteAllText(numberPath, Convert.ToString(contactNumber));
                            MessageBox.Show("Number added!");
                        }
                        else
                        {
                            Number.Text = "";
                            Number.Font = new Font("Segoe UI Semibold", 14);
                            Number.PlaceholderText = "Type a number";
                        }
                    }
                }
                else
                {
                    NameBox.Font = new Font("Segoe UI Semibold", 12);
                    NameBox.PlaceholderText = "Write a name";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured, please, send a message to the developer.");
                string logPath = @"C:\ContactBook\logs\contactCreationErrors.txt";
                File.AppendAllText(logPath, ex.Message);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu main = new MainMenu();
            main.Show();
        }
    }
}