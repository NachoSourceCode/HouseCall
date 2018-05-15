using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyGreatCourseProject.WebUI.Models
{
    public class ServiceOffer
    {
        public int ServiceOfferID { get; set; }

        // Navigation properties
        public virtual ICollection<Technician> Technicians { get; set; }
        public virtual ICollection<ServiceOffer> ServiceOffers { get; set; }
    }
}