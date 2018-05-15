using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyGreatCourseProject.WebUI.Models
{
    public class Trade
    {
        public char Industry { get; set; }
        public char TradeDescription { get; set; }

        //Navigation property
        public virtual ICollection<Technician> Technicians { get; set; }
    }
}