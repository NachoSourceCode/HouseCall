﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyGreatCourseProject.WebUI.Models
{
    public class Technician
    {
        public int TechnicianID { get; set; }
        public char Licenses { get; set; }
        public char Certifications { get; set; }
        public int JobsCompleted { get; set; }
        public decimal HourlyRate { get; set; }

        //Navigation properties
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<TechnicianCompany> TechniciansCompany { get; set; }
        public virtual ICollection<Trade> TradeOfTechnician { get; set; }
        public virtual ICollection<ServiceOffer> ServiceOffers { get; set; }
    }
}