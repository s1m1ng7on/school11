namespace Dictionary
{
    public static class Program
    {
        public static Dictionary Dictionary { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Dictionary = new Dictionary();
            Application.Run(new DictionaryForm());
        }
    }
}