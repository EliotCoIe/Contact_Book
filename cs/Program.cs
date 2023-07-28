namespace Hromov_ContactBook
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string path = @"C:\ContactBook\";
            string logPath = path + "logs";
            DirectoryInfo book = Directory.CreateDirectory(path);
            DirectoryInfo logs = Directory.CreateDirectory(logPath);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenu());
        }
    }
}