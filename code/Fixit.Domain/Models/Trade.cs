using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace Fixit.Domain.Models
{
    public class Trade
    {
        [Key]
        public string Industry { get; set; }
        public string TradeDescription { get; set; }

        //Navigation property
        public virtual ICollection<Technician> Technicians { get; set; }
    }
}