using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace Fixit.Domain.Models
{
    public class ServiceOffer
    {
        [Key]
        public int ServiceOfferID { get; set; }

        // Navigation properties
        public virtual ICollection<Technician> Technicians { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}