using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DDTrackPlusCommon.Models
{
    public class Order
    {
        /// <summary>
        /// Gets or sets the Id used internally by DDTrack Plus.
        /// </summary>
        public Int64 OrderLineId { get; set; }

        /// <summary>
        /// Gets or sets the Invoice Number.
        /// </summary>
        public String OrderNumber { get; set; }

        /// <summary>
        /// Gets or sets the Supplier Code used internally by FGH.
        /// </summary>
        /// 
        [Required]
  
        public Supplier SupplierDetails { get; set; }
        [Required]
      
        public string InvoiceNumber { get; set;  }

        /// <summary>
        /// Gets or sets the date the order was placed.
        /// </summary>
        public DateTime DateOfOrder { get; set; }

        /// <summary>
        /// Gets or sets the Despatch Promise Date.
        /// </summary>
        public DateTime DespatchPromiseDate { get; set; }

        /// <summary>
        /// Gets or sets the Delivery Promise Date.
        /// </summary>
        public DateTime DeliveryPromiseDate { get; set; }

        /// <summary>
        /// Gets or sets the customer delivery details.
        /// </summary>
        [Required]
        public CustomerDeliveryDetails CustomerDeliveryDetails { get; set; }

        /// <summary>
        /// Gets or sets the Item Number used internally by FGH.
        /// </summary>
        /// 
        [Required]
        public FGHItem ItemData { get; set; }
    
        /// <summary>
        /// Gets or sets the Barcode used at FGH.
        /// </summary>
        public String FGHBarcode { get; set; }

        /// <summary>
        /// Gets or sets the EAN.
        /// </summary>
        public String EAN { get; set; }

        /// <summary>
        /// Gets or sets the Cost Price.
        /// </summary>
        public Double CostPrice { get; set; }

        /// <summary>
        /// Gets or sets the Number Of Items.
        /// </summary>
        [Required]
        public Int32 NoOfItems { get; set; }

        /// <summary>
        /// Gets or sets the special requests on the Order Line.
        /// </summary>
        public List<string> SpecialRequests { get; set; }
        /// <summary>
        /// Gets or sets the Company Details used internally by FGH.
        /// </summary>
        public CompanyDetails Company;

        /// <summary>
        /// Gets or sets the Carrier details
        /// </summary>
        public CarrierDetails Carrier;

        /// <summary>
        /// Gets or sets the Van Round.
        /// </summary>
        /// <remarks>
        /// This is specific to the carrier being used.
        /// </remarks>
        public String VanRound { get; set; }

        public string ToJSON()
        {
            string JSON = String.Format("Order @@<@ \"InvoiceNumber: \"{0}\" @@>@",
                    InvoiceNumber);
            JSON = JSON.Replace("@@<@", "{");
            JSON = JSON.Replace("@@>@", "}");

            return JSON;
        }

        public Order()
        {
            SpecialRequests = new List<string>();
        }


    }

    public class OrderID
    {
        public long SupplierID;
        public long CompanyID;
        public long FGHItemID;
        public long CarrierID;
        public long CustomerDeliveryID;
        public long ID;

        public OrderID()
        {
            SupplierID = 0;
            CompanyID = 0;
            FGHItemID = 0;
            CarrierID = 0;
            CustomerDeliveryID = 0;
            ID = 0;
        }
        public bool isValid()
        {
            if (SupplierID == 0) return false;
            if (CompanyID == 0) return false;
            if (FGHItemID == 0) return false;
            if (CarrierID == 0) return false;
            if (CustomerDeliveryID == 0) return false;

            return true;
        }

        public string getInvalidIds()
        {
            string str = "";
            if (SupplierID == 0) str = String.Format("{0} SupplierID", str);
            if (CompanyID == 0) str = String.Format("{0} CompanyID", str);
            if (FGHItemID == 0) str = String.Format("{0} FGHItemID", str);
            if (CarrierID == 0) str = String.Format("{0} CarrierID", str);
            if (CustomerDeliveryID == 0) str = String.Format("{0} CustomerDeliveryID", str);

            return str;

        }
        public OrderID Copy()
        {
            return new OrderID
                { CarrierID = this.CarrierID
                , CompanyID = this.CompanyID
                , CustomerDeliveryID = this.CustomerDeliveryID
                , FGHItemID = this.FGHItemID
                , ID = this.ID
                , SupplierID = SupplierID };
        }
    }
}