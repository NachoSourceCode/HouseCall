using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace Fixit.Domain.Models
{
    public class ServiceRequest
    {
        [Key]
        public int ServiceRequestID { get; set; }
        public DateTime DateAndTime { get; set; }
        public string RequirementDescription { get; set; }

        //Navigation properties
        public virtual ICollection<ServiceOffer> ServiceOffers { get; set; }
        public virtual ICollection<Technician> Technicians { get; set; }
    }
}