namespace Exc1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public static double calFee(float distance)
        {
            if (distance <= 5)
            {
                return Math.Round(distance * 20_000, 2);
            }
            else if (distance > 5 && distance <= 20)
            {
                return Math.Round(5 * 20_000 + (distance - 5) * 15_000, 2);
            }
            else if (distance > 20 && distance <= 100)
            {
                return Math.Round(5 * 20_000 + 15 * 15_000 + (distance - 20) * 10_000, 2);
            }
            else
            {
                return Math.Round((5 * 20_000 + 15 * 15_000 + (distance - 20) * 10_000) * 0.1, 2);
            }
        }

    }
}