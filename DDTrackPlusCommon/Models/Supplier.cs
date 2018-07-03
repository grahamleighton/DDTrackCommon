using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DDTrackPlusCommon.Models
{
    public class NewSupplier
    {
       

        [DisplayName("Supplier Code")]
        [Required]
        [StringLength(maximumLength:4,MinimumLength =4,ErrorMessage = "Supplier Code must be 4 characters")]
        public string SupplierCode { get; set; }

        [DisplayName("Supplier Name")]
        [Required]
        public string SupplierName { get; set; }
     

        public string ToDisplay()
        {
            return String.Format("Supplier Code : {0} Supplier Name : {1}", SupplierCode, SupplierName);
        }
        public string ToJSON(string WithReplaceOpen = "", string WithReplaceClose = "")
        {
            string j = String.Format(" Supplier : @@>@ \"Supplier Code\": \"{0}\", \"Supplier Name\": \"{1}\" @@<@ ", SupplierCode, SupplierName);
            j = j.Replace("@@>@", "{");
            j = j.Replace("@@<@", "}");

            if ( ! String.IsNullOrEmpty(WithReplaceOpen) )
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


    }

    public class Supplier : NewSupplier 
    {
        private DateTime _date = DateTime.Now;

        [Key]
        [DisplayName("Supplier #")]
        [Required]
        public long SupplierID { get; set; }
        [DisplayName("Created On")]
        public DateTime CreatedOn
        {
            get { return _date; }
            set { _date = value; }
        }

    }
}