namespace Hromov_ContactBook
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void ContactSettingsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Find findForm = new Find();
            findForm.Show();
        }
        private void Create_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create createForm = new Create();
            createForm.Show();
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}