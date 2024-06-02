namespace School
{
    public static class Program
    {
        public static School School { get; set; }

        public static Form MainForm { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            School = new School();

            MainForm = new SchoolPanel();
            Application.Run(MainForm);
        }
    }
}