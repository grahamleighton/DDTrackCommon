using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DDTrackPlusCommon.Models
{
    public class CarrierDetails
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }

        public string ToJSON()
        {
            string JSon = String.Format("Carrier @@<@ Code: \"{0}\", Name: \"{1}\" @@>@", Code, Name);
            JSon = JSon.Replace("@@<@", "{");
            JSon = JSon.Replace("@@>@", "}");
            return JSon;
                
        }
    }
}