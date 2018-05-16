using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fixit.Domain.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetName { get; set; }
        public string CityName { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public long PrimaryPhoneNumber { get; set; }

        //Navigation property
        public virtual ICollection<ServiceRequest> ServiceRequests { get; set; }
        
    }
}