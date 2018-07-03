using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDTrackPlusCommon.Models
{
    public class IDataExpectedException : Exception
    {
        public IDataExpectedException(string message) : base(message)
        {
        }
    }
}