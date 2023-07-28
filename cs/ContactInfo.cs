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
    public partial class ContactInfo : Form
    {
        public ContactInfo()
        {
            InitializeComponent();
        }
        private void ContactInfo_Load(object sender, EventArgs e)
        {
            string contactName = DataTransfer.contactName;
            string path = @"C:\ContactBook\";
            ContactNameLabel.Text = "Name: " + contactName;
            string numberPath = path + contactName + @"\number.txt";
            if (File.Exists(numberPath))
            {
                ContactNumberLabel.Text = "Number: " + File.ReadAllText(numberPath);
            }
            else
            {
                ContactNumberLabel.Text = "Number is absent";
            }
            string skypePath = path + "skype.txt";
            if (File.Exists(skypePath))
            {
                ContactSkypeLabel.Text = "Skype: " + File.ReadAllText(skypePath);
            }
            else
            {
                ContactSkypeLabel.Text = "Skype is absent";
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Hide();
            Find findForm = new Find();
            findForm.Show();
        }
    }
}
