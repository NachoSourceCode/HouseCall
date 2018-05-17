using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Fixit.Domain;
using System.Text;
using System.Threading.Tasks;

using Fixit.Domain.Models;
    
namespace Fixit.Domain.DAL
{
    
    public class UserInitializer : System.Data.Entity.DropCreateDatabaseAlways<UserContext>  // DropCreateDatabaseIfModelChanges<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            var users = new List<User>
            {

                new User{UserID = 1, FirstName="Matthew", LastName="Slone", StreetName="222 Slonez Street", CityName="Oakland", State="MD", Zip=21550, PrimaryPhoneNumber=13015016957},
                new User{UserID = 2, FirstName="Greg", LastName="Wilson", StreetName="222 Greg Street", CityName="Daytona", State="FL", Zip=32114, PrimaryPhoneNumber=11213435555},
                new User{UserID = 3, FirstName="Julio", LastName="Juarez", StreetName="222 Julio Street", CityName="Houston", State="TX", Zip=77001, PrimaryPhoneNumber=14546768888},
                new User{UserID = 4, FirstName="Roy", LastName="Lovitt", StreetName="222 Roy Street", CityName="Redmond", State="WA", Zip=98008, PrimaryPhoneNumber=11111115555},
                new User{UserID = 5, FirstName="Tim", LastName="Tebow", StreetName="222 Tebow Time Street", CityName="Maui", State="HI", Zip=96708, PrimaryPhoneNumber=13334445555},
                new User{UserID = 6, FirstName="Sharon", LastName="Wheeler", StreetName="222 Wheeler Street", CityName="Maui", State="HI", Zip=96708, PrimaryPhoneNumber=17773435577},
                new User{UserID = 7, FirstName="Francis", LastName="Carter", StreetName="222 Carter Street", CityName="Redmond", State="WA", Zip=98008, PrimaryPhoneNumber=13334445555},
                new User{UserID = 8, FirstName="Angelica", LastName="Valdez", StreetName="222 Valdez Street", CityName="Houston", State="TX", Zip=77001, PrimaryPhoneNumber=13334995544},
                new User{UserID = 9, FirstName="Carroll", LastName="Fletcher", StreetName="222 Fletcher Street", CityName="Daytona", State="FL", Zip=32114, PrimaryPhoneNumber=13334885555},
                new User{UserID = 10,FirstName="Bessie", LastName="Klein", StreetName="222 Klien Street", CityName="Oakland", State="MD", Zip=21550, PrimaryPhoneNumber=13334775555}

            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var technicians = new List<Technician>
            {

                new Technician{TechnicianID = 1, Licenses = "Cleaning License", Certifications = "FixitCleaningCert", JobsCompleted = 2, HourlyRate = 18.00m},
                new Technician{TechnicianID = 2, Licenses = "Handyman License", Certifications = "FixitHandymanCert", JobsCompleted = 4, HourlyRate = 18.99m},
                new Technician{TechnicianID = 3, Licenses = "Plumbing License", Certifications = "FixitPlumbingCert", JobsCompleted = 1, HourlyRate = 25.50m},
                new Technician{TechnicianID = 4, Licenses = "Electrical License", Certifications = "FixitElectricalCert", JobsCompleted = 2, HourlyRate = 26.75m},
                new Technician{TechnicianID = 5, Licenses = "Haulaway License", Certifications = "FixitHaulawayCert", JobsCompleted = 1, HourlyRate = 12.25m}

            };

            technicians.ForEach(t => context.Technicians.Add(t));
            context.SaveChanges();

            var serviceRequests = new List<ServiceRequest>
            {

                new ServiceRequest{ServiceRequestID = 1, DateAndTime = new DateTime (2010, 8 , 18), RequirementDescription = "Please clean my dirty house."},
                new ServiceRequest{ServiceRequestID = 2, DateAndTime = new DateTime (2010, 8, 24), RequirementDescription = "The lights in my basement will not turn on."},
                new ServiceRequest{ServiceRequestID = 3, DateAndTime = new DateTime (2010, 9, 1), RequirementDescription = "The lights in my basement will not turn on."},
                new ServiceRequest{ServiceRequestID = 4, DateAndTime = new DateTime (2010, 9, 4), RequirementDescription = "Please replace all light bulbs out for LED bulbs in entire house."},
                new ServiceRequest{ServiceRequestID = 5, DateAndTime = new DateTime (2011, 1, 12), RequirementDescription = "Please replace all light bulbs out for LED bulbs in entire house."},
                new ServiceRequest{ServiceRequestID = 6, DateAndTime = new DateTime (2011, 1, 14), RequirementDescription = "Please replace all light bulbs out for LED bulbs in entire house."},
                new ServiceRequest{ServiceRequestID = 7, DateAndTime = new DateTime (2011, 2, 10), RequirementDescription = "Please replace all light bulbs out for LED bulbs in entire house."},
                new ServiceRequest{ServiceRequestID = 8, DateAndTime = new DateTime (2012, 3, 10), RequirementDescription = "Please clean my dirty house."},
                new ServiceRequest{ServiceRequestID = 9, DateAndTime = new DateTime (2013, 3, 11), RequirementDescription = "Please replace the seal on my toilet. It leaks."},
                new ServiceRequest{ServiceRequestID = 10, DateAndTime = new DateTime (2014, 4, 12), RequirementDescription = "Please clean out my basement. Throw out everything."}
                

            };

            serviceRequests.ForEach(sr => context.ServiceRequests.Add(sr));
            context.SaveChanges();

            var serviceOffers = new List<ServiceOffer>
            {

                new ServiceOffer{ServiceOfferID = 1},
                new ServiceOffer{ServiceOfferID = 2},
                new ServiceOffer{ServiceOfferID = 3},
                new ServiceOffer{ServiceOfferID = 4},
                new ServiceOffer{ServiceOfferID = 5},
                new ServiceOffer{ServiceOfferID = 6},
                new ServiceOffer{ServiceOfferID = 7},
                new ServiceOffer{ServiceOfferID = 8},
                new ServiceOffer{ServiceOfferID = 9},
                new ServiceOffer{ServiceOfferID = 10}

            };

            serviceOffers.ForEach(so => context.ServiceOffers.Add(so));
            context.SaveChanges();

            var trade = new List<Trade>
            {
                new Trade{Industry = "Cleaning", TradeDescription = "They clean things."},
                new Trade{Industry = "Electrical", TradeDescription = "They fix electrical things."},
                new Trade{Industry = "Plumbing", TradeDescription = "They fix plumbing things."},
                new Trade{Industry = "Handyman", TradeDescription = "They do any and all other odd jobs not done by specific trades people."},
                new Trade{Industry = "Haulaway", TradeDescription = "They remove stuff you no longer want from your property."}
            };

            trade.ForEach(trd => context.Trades.Add(trd));
            context.SaveChanges();

            var techniciansCompany = new List<TechnicianCompany>
            {

                new TechnicianCompany{CompanyName = "CleaningCompany", StreetName = "1200 Cleaning Street", CityName = "Maui", Zip = 96708},
                new TechnicianCompany{CompanyName = "ElectricalCompany", StreetName = "1200 Electric Avenue", CityName = "Redmond", Zip = 98008},
                new TechnicianCompany{CompanyName = "PlumbingCompany", StreetName = "1200 Plumbing Way", CityName = "Houston", Zip = 97001},
                new TechnicianCompany{CompanyName = "HandymanCompany", StreetName = "1200 Handyman Lane", CityName = "Daytona", Zip = 32114},
                new TechnicianCompany{CompanyName = "HaulawayCompany", StreetName = "1200 Haulaway Circle", CityName = "Oakland", Zip = 21550}

            };

            techniciansCompany.ForEach(tc => context.TechniciansCompany.Add(tc));
            context.SaveChanges();


            var bookings = new List<Booking>
            {
                new Booking{BookingID = 1, UserRating = 5, PaymentStatus = true, PaymentDetails = PaymentType.CreditDebit},
                new Booking{BookingID = 2, UserRating = 5, PaymentStatus = false, PaymentDetails = PaymentType.Check},
                new Booking{BookingID = 3, UserRating = 4, PaymentStatus = false, PaymentDetails = PaymentType.Cash},
                new Booking{BookingID = 4, UserRating = 4, PaymentStatus = true, PaymentDetails = PaymentType.Cash},
                new Booking{BookingID = 5, UserRating = 4, PaymentStatus = true, PaymentDetails = PaymentType.CreditDebit},
                new Booking{BookingID = 6, UserRating = 3, PaymentStatus = true, PaymentDetails = PaymentType.Cash},
                new Booking{BookingID = 7, UserRating = 5, PaymentStatus = true, PaymentDetails = PaymentType.Cash},
                new Booking{BookingID = 8, UserRating = 2, PaymentStatus = true, PaymentDetails = PaymentType.CreditDebit},
                new Booking{BookingID = 9, UserRating = 1, PaymentStatus = false, PaymentDetails = PaymentType.CreditDebit},
                new Booking{BookingID = 10, UserRating = 3, PaymentStatus = true, PaymentDetails = PaymentType.CreditDebit}
            };

            bookings.ForEach(b => context.Bookings.Add(b));
            context.SaveChanges();

        }

    }
}
