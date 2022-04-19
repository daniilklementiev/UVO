using NLog;
using Unity;

namespace UVO
{
    internal static class Program
    {
        public static UnityContainer Container { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // Dependency injection container
            Container = new UnityContainer();
            // Additional configurator
            // NLog
            var nlogConfig = new NLog.Config.LoggingConfiguration();
            nlogConfig.AddRule(LogLevel.Trace, LogLevel.Fatal,
                new NLog.Targets.FileTarget("fileTarget")
                {
                    FileName = "log.txt"
                });

            NLog.LogManager.Configuration = nlogConfig;
            Logger logger = NLog.LogManager.GetCurrentClassLogger();
            // Register logger;
            Container.RegisterInstance(logger);

            ApplicationConfiguration.Initialize();
            Application.Run(Container.Resolve<Forms.Game>());
        }
    }
}