using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DDTrackPlusCommon.Models
{
    /// <summary>
    /// Hold the fields that represent the Order key
    /// 
    /// </summary>
    public class OrderKey
    {
        /// <summary>
        /// Gets or sets the Invoice Number.
        /// </summary>
        [Required]
        public String OrderNumber { get; set; }
        /// <summary>
        /// Gets or sets the date the order was placed.
        /// </summary>
        [Required]
        public Nullable<System.DateTime> DateOfOrder { get; set; }
        /// <summary>
        /// Gets or sets the Customer Account Ref No
        /// </summary>
        [Required]
        public string CustomerAccount { get; set; }
        /// <summary>
        /// Gets or sets the supplier code
        /// </summary>
        [Required]
        public string SupplierCode { get; set; }


        public OrderKey()
        {
            CustomerAccount = "";
            SupplierCode = "";
            DateOfOrder = null;
            OrderNumber = "";

        }

        public void Reset()
        {
            CustomerAccount = "";
            SupplierCode = "";
            DateOfOrder = null;
            OrderNumber = "";

        }

        public void ImportFromOrder(Order o)
        {
            if ( !String.IsNullOrEmpty(o.OrderNumber ) )
                this.OrderNumber = o.OrderNumber;
            if ( o.DateOfOrder != null )
                this.DateOfOrder = o.DateOfOrder;
            if ( o.CustomerDeliveryDetails != null )
            {
                if ( !String.IsNullOrEmpty(o.CustomerDeliveryDetails.AccountNumber))
                {
                    this.CustomerAccount = o.CustomerDeliveryDetails.AccountNumber;
                }
            }

            if ( o.SupplierDetails != null )
                this.SupplierCode = o.SupplierDetails.SupplierCode;
            
        }
    }
}