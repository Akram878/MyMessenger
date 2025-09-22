namespace MyMessenger
{
    internal static class Program
    {



        public static Login log;
        public static Register reg;
        public static List<User> users = new List<User>();

        /// <summary>
        /// 
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

             log = new Login();
             reg = new Register();

            // تشغيل البرنامج على الفورم الذي يُفتح أولًا
            Application.Run(log);
        }
    }
}