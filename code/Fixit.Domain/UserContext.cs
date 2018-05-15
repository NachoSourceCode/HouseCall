using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;

using Fixit.WebUI.Models;

namespace Fixit.Domain
{
    public class UserContext : DbContext
    {

        //Constructor : Connection String
        public UserContext() : base("UserContext")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<ServiceRequest> ServiceRequests { get; set; }
        public DbSet<ServiceOffer> ServiceOffers { get; set; }
        public DbSet<Technician> Technicians { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }
}
