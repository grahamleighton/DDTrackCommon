using Serilog;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace DDTrackPlusCommon.Models
{
        public static class Logging
        {
            /// <summary>
            /// Configures logging for the application.
            /// </summary>
            public static void ConfigureLogging()
            {
                const String APPLICATION_DIRECTORY_VARIABLE = "BASEDIR";

                // Set an environment variable (current process only) for serilog to use for the application directory.
                Environment.SetEnvironmentVariable(APPLICATION_DIRECTORY_VARIABLE, AppDomain.CurrentDomain.BaseDirectory);

            // Configure the logger for the application.
            /*
             * Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Is(Serilog.Events.LogEventLevel.Debug)
                .ReadFrom.AppSettings()
                .CreateLogger();
            */
            string seridir = ConfigurationManager.AppSettings["SeriDirectory"];
            Log.Logger = new LoggerConfiguration()
                      .MinimumLevel.Information()
                      .WriteTo.File(String.Format("{0}/{1}.txt", seridir, DateTime.Now.ToString("ddMMyyyyHH")))
                      .CreateLogger();

            // Set the process exit event so that the logger can be flushed before closing.
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
            }

            /// <summary>
            /// Flushes the logger when the application process exists.
            /// </summary>
            /// <param name="sender">The sender of the event.</param>
            /// <param name="e">The event arguments.</param>
            private static void OnProcessExit(Object sender, EventArgs e)
            {
                Log.CloseAndFlush();
            }
    }
}