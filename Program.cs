using Coffee_shop.shop;
using System.Timers;

namespace Coffee_shop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        //static void Main()
        //{
        //    // To customize application configuration such as set high DPI settings or default font,
        //    // see https://aka.ms/applicationconfiguration.
        //    ApplicationConfiguration.Initialize();

        //    Program.daher
        //        .ReadAllData("AdminAdd.txt", "AdminDelete.txt","UserTransactions.txt");

        //    Application.Run(new LoginForm());
        //}


        //public static Shop daher = new Shop(2);
        //public static string User;
        //public static string datetime = DateTime.Now.ToString("hh:mm:ss.fff");
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Program.daher
                .ReadAllData("AdminAdd.txt", "AdminDelete.txt", "UserTransactions.txt");

            // Create a timer with a 1 second interval
            System.Timers.Timer timer = new System.Timers.Timer(1000);

            // Hook up the Elapsed event for the timer
            timer.Elapsed += OnTimedEvent;

            // Start the timer
            timer.Enabled = true;

            Application.Run(new LoginForm());
        }

        static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            // Update the datetime variable with the current time
            Program.datetime = DateTime.Now.ToString("hh:mm:ss");
        }

        public static Shop daher = new Shop(2);
        public static string User;
        public static string datetime = DateTime.Now.ToString("hh:mm:ss");
    }
}