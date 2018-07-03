using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DDTrackPlusCommon.Models
{
    public class FGHOptionNumber
    {
        [Required]
        public String OptionNumber { get; set; }

        /// <summary>
        /// Gets or sets the Option Description.
        /// </summary>
        public String OptionDescription { get; set; }

        /// <summary>
        /// Gets or sets the Item Number determined by the supplier.
        /// </summary>
        public String SupplierItemNumber { get; set; }
        /// <summary>
        /// Gets or sets the Option Weight
        /// </summary>
        public float OptionWeight { get; set; }

        public string ToJSON()
        {
            string JSON = "";

            JSON = String.Format("FGHOptionNumber @>@ OptionNumber: \"{0}\", OptionDescription: \"{1}\", SupplierItemNumber: \"{2}\", OptionWeight: \"{3}\" @<@",
                    OptionNumber, OptionDescription, SupplierItemNumber, OptionWeight);
            JSON = JSON.Replace("@>@", "{");
            JSON = JSON.Replace("@<@", "}");
            return JSON;

        }
    }
}