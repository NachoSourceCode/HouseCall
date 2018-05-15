using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fixit.WebUI.Models
{
    public class TechnicianCompany
    {
        public char CompanyName { get; set; }
        public char StreetName { get; set; }
        public string CityName { get; set; }
        public int Zip { get; set; }

        //Navigation property
        public virtual ICollection<Technician> Technicians { get; set; }
    }
}