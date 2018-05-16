using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fixit.Domain.Models
{
    public class ServiceOffer
    {
        public int ServiceOfferID { get; set; }

        // Navigation properties
        public virtual ICollection<Technician> Technicians { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}