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
    public partial class Change : Form
    {
        public Change()
        {
            InitializeComponent();
        }
        string path = @"C:\ContactBook\";
        string contactName = DataTransfer.contactName;
        private void ChangeNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                string newName = NameInput.Text;
                string newContactPath = path + newName;
                Directory.Move(path + contactName, newContactPath);
                MessageBox.Show(contactName + " has been changed to " + newName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured, please, send a message to the developer.");
                string logPath = path + @"logs\nameChangeErrors.txt";
                File.AppendAllText(logPath, ex.Message);
            }
        }
        private void ChangeNumberButton_Click(object sender, EventArgs e)
        {
            string newNumber = NumberInput.Text;
            string numberPath = path + contactName + @"\number.txt";
            try
            {
                string logPath = path + @"logs\previousNumbers.txt";
                int previousNumber = Convert.ToInt32(File.ReadAllText(numberPath));
                File.AppendAllText(logPath, contactName + ": " + Convert.ToString(previousNumber) + Environment.NewLine);
                File.WriteAllText(numberPath, newNumber);
                MessageBox.Show(previousNumber + " has been change to " + newNumber);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured, please, send a message to the developer.");
                string logPath = path + @"logs\numberChangeErrors.txt";
                File.AppendAllText(logPath, ex.Message);
            }
        }

        private void SkypeSettingsButton_Click(object sender, EventArgs e)
        {
            string skypePath = path + "skype.txt";
            string newSkype = SkypeInput.Text;
            if (File.Exists(skypePath))
            {
                string logPath = path + @"logs\previousSkypes.txt";
                string previousSkype = File.ReadAllText(skypePath);
                File.AppendAllText(logPath, contactName + ": " + previousSkype + Environment.NewLine);
                File.WriteAllText(skypePath, newSkype);
                MessageBox.Show(previousSkype + " has been changed to " + newSkype);
            }
            else
            {
                skypePath = path + "skype.txt";
                File.AppendAllText(skypePath, newSkype);
                MessageBox.Show(newSkype + " has been added to your contacts info");
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