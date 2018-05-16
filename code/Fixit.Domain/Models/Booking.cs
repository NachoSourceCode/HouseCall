using System;
using System.Collections.Generic;
using System.Text;

namespace Fixit.Domain.Models
{
    public enum PaymentType {CreditDebit, Cash, Check  }

    public class Booking
    {
        
        public int BookingID { get; set; }
        public int UserRating { get; set; }
        public bool PaymentStatus { get; set; }
        public PaymentType PaymentDetails { get; set; }

        //Navigation property
        public virtual ICollection<ServiceOffer> ServiceOffers { get; set; }
    }
}
