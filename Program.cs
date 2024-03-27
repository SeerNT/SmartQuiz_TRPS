namespace SmartQuiz
{
    internal static class Program
    {
        public static Authorization authForm;
        public static Registration registerForm;
        public static TestTypeChoice testForm;
        public static Questions questionsDesignerForm;
        public static UserTest userTestForm;


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
            testForm = new TestTypeChoice();
            questionsDesignerForm = new Questions();
            userTestForm = new UserTest();
            authForm.Show();
            Application.Run();
        }
    }
}