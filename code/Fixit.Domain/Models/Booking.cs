using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace Fixit.Domain.Models
{
    public enum PaymentType {CreditDebit, Cash, Check  }
    
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }
        public int UserRating { get; set; }
        public bool PaymentStatus { get; set; }
        public PaymentType PaymentDetails { get; set; }

        //Navigation property
        public virtual ICollection<ServiceOffer> ServiceOffers { get; set; }
    }
}
