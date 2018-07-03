using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDTrackPlusCommon.Models
{
    public class CompanyAddress
    {
        /// <summary>
        /// Gets or sets the line 1 of the company address.
        /// </summary>
        public String Line1 { get; set; }

        /// <summary>
        /// Gets or sets the line 2 of the company address
        /// </summary>
        public String Line2 { get; set; }

        /// <summary>
        /// Gets or sets the line 3 of the company address
        /// </summary>
        public String Line3 { get; set; }

        /// <summary>
        /// Gets or sets the town of the company address
        /// </summary>
        public String Town { get; set; }

        /// <summary>
        /// Gets or sets the county of the company address
        /// </summary>
        public String County { get; set; }

        /// <summary>
        /// Gets or sets the postcode for the company address.
        /// </summary>
        public String Postcode { get; set; }

        public string ToJSON()
        {
            string JSON = "";

            JSON = String.Format(" CompanyAddress: @@<@ \"Line1\":  \"{0}\", \"Line2\":  \"{1}\", \"Line3\":  \"{2}\", \"Town\": \"{3}\", \"County\":\"{4}\", \"Postcode\": \"{5}\" @@>@",
                Line1, Line2, Line3, Town, County, Postcode);
            JSON = JSON.Replace("@@<@", "{");
            JSON = JSON.Replace("@@>@", "}");
            return JSON;
        }
    }
}