using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Web;





namespace DDTrackPlusCommon.Models
{
    public enum returnValue { RETURN_SUCCESS = 0, RETURN_FAILURE , RETURN_INVALIDARGS , RETURN_DATAEXPECTED};
    public enum checkBehavior {  RETURN_ERROR = 0, RETURN_DEFAULT }
    public enum AdminLevelEnum { SYSTEM_ADMINISTRATOR = 0 , SUPPLIER_ADMINISTRATOR, USER , READONLY_USER ,DDADMIN , FTUSER }
    public class Common
    {
    }

  

    public class DataExpectedException : Exception
    {
        public DataExpectedException(string message) : base(message)
        {
        }
    }

   
}