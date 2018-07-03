using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DDTrackPlusCommon.Models
{
    public class FGHItem
    {
        [Required]
        public String FGHItemNumber { get; set; }

        /// <summary>
        /// Gets or sets the Item Description.
        /// </summary>
        public String FGHItemDescription { get; set; }

        public List<FGHOptionNumber> OptionData { get; set; }

        public FGHItem()
        {
            OptionData = new List<FGHOptionNumber>();
        }

        public string ToJSON(int i, string WithReplaceOpen = "", string WithReplaceClose = "")
        {
            string JSON = "";

            if (i > OptionData.Count)
                i = 0;
            
            JSON = String.Format("FGHItem : @@>@ \"FGHItemNumber: \"{0}\", FGHItemDescription: \"{1}\", {2} @@<@",
                    FGHItemNumber, FGHItemDescription, OptionData[i].ToJSON());
            JSON = JSON.Replace("@@>@", "{");
            JSON = JSON.Replace("@@<@", "}");

           
            if (!String.IsNullOrEmpty(WithReplaceOpen))
            {
                if (String.IsNullOrEmpty(WithReplaceClose))
                {
                    JSON = JSON.Replace("{", WithReplaceOpen + ">");
                    JSON = JSON.Replace("}", WithReplaceOpen + "<");
                }
                else
                {
                    JSON = JSON.Replace("{", WithReplaceOpen);
                    JSON = JSON.Replace("}", WithReplaceClose);
                }
            }
           


            return JSON;
        }

        public string ToJSON(FGHOptionNumber optData)
        {
            string JSON = "";

            string JSON2 = optData.ToJSON();
            JSON2.Replace("{", "@@>@");
            JSON2.Replace("}", "@@<@");

            JSON = String.Format("FGHItem @@>@ \"FGHItemNumber: \"{0}\", FGHItemDescription: \"{1}\", {2} @@<@",
                    FGHItemNumber, FGHItemDescription, JSON2);
            JSON = JSON.Replace("@@>@", "{");
            JSON = JSON.Replace("@@<@", "}");


            return JSON;
        }

    }
}