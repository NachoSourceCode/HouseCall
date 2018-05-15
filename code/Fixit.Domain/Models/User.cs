using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fixit.WebUI.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char StreetName { get; set; }
        public string CityName { get; set; }
        public char State { get; set; }
        public int Zip { get; set; }
        public char PrimaryPhoneNumber { get; set; }

        //Navigation property
        public virtual ICollection<ServiceRequest> ServiceRequests { get; set; }
        
    }
}