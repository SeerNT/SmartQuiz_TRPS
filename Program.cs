namespace SmartQuiz
{
    internal static class Program
    {
        public static Authorization authForm;
        public static Registration registerForm;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            authForm = new Authorization();
            registerForm = new Registration();
            authForm.Show();
            Application.Run();
        }
    }
}