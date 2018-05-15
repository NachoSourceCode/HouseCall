using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyGreatCourseProject.WebUI.Models
{
    public class ServiceRequest
    {
        public int ServiceRequestID { get; set; }
        public DateTime DateAndTime { get; set; }
        public char RequirementDescription { get; set; }

        //Navigation properties
        public virtual ICollection<ServiceOffer> ServiceOffers { get; set; }
        public virtual ICollection<Technician> Technicians { get; set; }
    }
}