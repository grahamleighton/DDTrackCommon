using Serilog;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDTrackPlusCommon.Controllers
{
    public class LogController : Controller
    {
       

        public LogController()
        {
            string seridir = ConfigurationManager.AppSettings["SeriDirectory"];
            Log.Logger = new LoggerConfiguration()
                        .MinimumLevel.Information()
                        .WriteTo.File(String.Format("{0}/{1}.txt", seridir,DateTime.Now.ToString("ddMMyyyy")))
                        .CreateLogger();
           
        }

/*        public void CreateLogger()
        {
            string seridir = ConfigurationManager.AppSettings["SeriDirectory"];
            Log.Logger = new LoggerConfiguration()
                            .MinimumLevel.Information()
                            .WriteTo.File(String.Format("{0}/{1}.txt", seridir, DateTime.Now.ToString("ddMMyyyy")))
                            .CreateLogger();
        }
   */

        public void Information ( string msg )
        {
            string seridir = ConfigurationManager.AppSettings["SeriDirectory"];
            Log.Logger = new LoggerConfiguration()
                            .MinimumLevel.Information()
                            .WriteTo.File(String.Format("{0}/{1}.txt", seridir, DateTime.Now.ToString("ddMMyyyy")))
                            .CreateLogger();
       
        Log.Information("User {0}:  {1}", User.Identity.Name, msg);
            

        }
        public void Error(Exception ex)
        {
            string seridir = ConfigurationManager.AppSettings["SeriDirectory"];
            Log.Logger = new LoggerConfiguration()
                            .MinimumLevel.Information()
                            .WriteTo.File(String.Format("{0}/{1}.txt", seridir, DateTime.Now.ToString("ddMMyyyy")))
                            .CreateLogger();

            Log.Error("User {0}:  {1}", User.Identity.Name, ex.Message);

        }
        // GET: Log



    }
}