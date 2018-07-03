using System;
using System.Configuration;
using System.Web.Mvc;

namespace DDTrackPlusCommon.Controllers
{
    public class CommonDataController : Controller
    {
        // GET: Data
        public SQLController sql = new SQLController(ConfigurationManager.AppSettings["DDTrackPlusDBConn"]);

        private static string em = "";

        public String _controllerName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String _actionName { get; set; }
        public String getCaller(String Procedure = "")
        {
            if (Procedure == "")
            {
                return String.Format("{0}/{1}", _controllerName, _actionName);
            }
            return String.Format("{0}/{1} Procedure : {2} ", _controllerName, _actionName, Procedure);

        }
        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="Result"></param>
        /// <param name="Procedure"></param>
        /// <returns></returns>
        public String getCaller(String Result, String Procedure = "")
        {
            if (Procedure == "")
            {
                return String.Format("{0}/{1} {2} ", _controllerName, _actionName, Result);
            }
            return String.Format("{0}/{1} {2} Procedure : {3} ", _controllerName, _actionName, Result, Procedure);

        }

        /*
         *  Error related functions
         *
         *
         * 
         */

        public string getError()
        {
            return em;
        }
        public string getLastError()
        {
            return getError();
        }
        public bool Error()
        {
            return !String.IsNullOrEmpty(em);
        }
        public void clearError()
        {
            em = "";
        }
        public void setError(string errorMessage)
        {
            em = errorMessage;
        }

     
    }
}