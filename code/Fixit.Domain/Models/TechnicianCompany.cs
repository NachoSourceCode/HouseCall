using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fixit.Domain.Models
{
    public class TechnicianCompany
    {
        public string CompanyName { get; set; }
        public string StreetName { get; set; }
        public string CityName { get; set; }
        public int Zip { get; set; }

        //Navigation property
        public virtual ICollection<Technician> Technicians { get; set; }
    }
}