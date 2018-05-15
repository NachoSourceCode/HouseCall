using System;
using System.Collections.Generic;
using System.Text;

namespace Fixit.WebUI.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int UserRating { get; set; }
        public char PaymentStatus { get; set; }
        public char PaymentDetails { get; set; }

        //Navigation property
        public virtual ICollection<ServiceOffer> ServiceOffers { get; set; }
    }
}
