using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;

using Fixit.Domain.Models;

namespace Fixit.Domain.DAL
{
    public class UserContext : DbContext
    {

        //Constructor : Connection String
        public UserContext()
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<ServiceRequest> ServiceRequests { get; set; }
        public DbSet<ServiceOffer> ServiceOffers { get; set; }
        public DbSet<Technician> Technicians { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Trade> Trades { get; set; }
        public DbSet<TechnicianCompany> TechniciansCompany { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }
}
