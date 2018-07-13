using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DDTrackPlusCommon.Models
{
    /// <summary>
    /// ionfosadjkvhsdf
    /// </summary>
    public class CompanyDetails
    {
        /// <summary>
        /// Gets or sets the Company Code used internally by FGH.
        /// </summary>
        [Required]
        [MaxLength(4)]
        public String CompanyCode { get; set; }

        /// <summary>
        /// Gets or sets the Company Name.
        /// </summary>
        [MaxLength(60)]
        [Required]
        public String CompanyName { get; set; }

        /// <summary>
        /// The business address of the company.
        /// </summary>
        public CompanyAddress CompanyBusinessAddress { get; set; }

        /// <summary>
        /// The return address of the company.
        /// </summary>
        public CompanyAddress CompanyReturnAddress { get; set; }

        public string ToJSON(string WithReplaceOpen = "", string WithReplaceClose = "")
        {
            string j = String.Format("Company : @@>@ \"Company Code\": \"{0}\", \"Company Name\": \"{1}\" @@<@ ", CompanyCode, CompanyName);

            j = j.Replace("@@>@", "{");
            j = j.Replace("@@<@", "}");

            if (!String.IsNullOrEmpty(WithReplaceOpen))
            {
                if (String.IsNullOrEmpty(WithReplaceClose))
                {
                    j = j.Replace("{", WithReplaceOpen + ">");
                    j = j.Replace("}", WithReplaceOpen + "<");
                }
                else
                {
                    j = j.Replace("{", WithReplaceOpen);
                    j = j.Replace("}", WithReplaceClose);
                }
            }
            return j;

        }
        public string ToDisplay()
        {
            string j = String.Format(" CompanyDetails : \"Company Code\" : \"{0}\", \"Company Name\" : \"{1}\" ", CompanyCode, CompanyName);
            return j;
        }
    }
  
}