using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DDTrackPlusCommon.Models
{
    public class CustomerDeliveryDetails
    {
        /// <summary>
        /// Gets or sets the Customer Account Number.
        /// </summary>
        [Required]
        [StringLength(10,ErrorMessage ="Account number should be no more than 10 characters")]
        public String AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the Customer Name.
        /// </summary>
        [Required]
        public String CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the line 1 of the delivery address.
        /// </summary>

        [Required]
        public String Line1 { get; set; }

            /// <summary>
            /// Gets or sets the line 2 of the delivery address
            /// </summary>
            public String Line2 { get; set; }

            /// <summary>
            /// Gets or sets the line 3 of the delivery address
            /// </summary>
            public String Line3 { get; set; }

            /// <summary>
            /// Gets or sets the line 4 of the delivery address
            /// </summary>
            public String Line4 { get; set; }

            /// <summary>
            /// Gets or sets the line 5 of the delivery address
            /// </summary>
            public String Line5 { get; set; }

            /// <summary>
            /// Gets or sets the line 6 of the delivery address
            /// </summary>
            public String Line6 { get; set; }

        /// <summary>
        /// Gets or sets the Postcode for the delivery address.
        /// </summary>
        [Required]
        public String Postcode { get; set; }

            /// <summary>
            /// Gets or sets the Country for the delivery address.
            /// </summary>
            public String Country { get; set; }

            /// <summary>
            /// Gets or sets the Email Address for the customer.
            /// </summary>
            public String EmailAddress { get; set; }

            /// <summary>
            /// Gets or sets the primary phone number for the customer.
            /// </summary>
            public String PhoneNumber1 { get; set; }

            /// <summary>
            /// Gets or sets the secondary phone number for the customer.
            /// </summary>
            public String PhoneNumber2 { get; set; }

        public String ToJSON()
        {
            string JSON = String.Format("@@<@  AccountNumber: \"{0}\", CustomerName: \"{1}\", Line1: \"{2}\", Line2: \"{3}\", Line3: \"{4}\", Line4: \"{5}\", Line5: \"{6}\", Line6: \"{7}\", Postcode: \"{8}\", Country: \"{9}\", EmailAddress: \"{10}\", PhoneNumber1: \"{11}\" , PhoneNumber2: \"{12}\" @@>@",
                    AccountNumber, CustomerName, Line1, Line2, Line3, Line4, Line5, Line6, Postcode, Country, EmailAddress, PhoneNumber1, PhoneNumber2);
            JSON = JSON.Replace("@@<@", "{");
            JSON = JSON.Replace("@@>@", "}");
            return JSON;
        }


    }


}