using System;
using System.Collections.Generic;
using HADatabaseEntity;

namespace HospitalAppointment.DataAccess
{
    public class HaInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<HaContext>
    {
        protected override void Seed(HaContext context)
        {
            var patient = new List<Patient>
            {
                new Patient { PatientId = new Guid("be8e67a2-06e5-489b-b0fe-c95b1a8f3565"), FirstName = "Andrii",
                    LastName = "Zozulia", SecondName = "a", Role = "Admin", Email = "for.vntu@gmail.com",
                    Login = "Admin", Hash = "sha1:64000:18:4Ae4Bf481pJ2ZoZppcsvUuQTLZE39UED:8omAyfYy9G7ZYIVNY6A+Fp7N",
                    Address = new Address {AddressId =  new Guid("cba2292c-eebf-4765-a7a3-0e79675caf8f"), StreetName = "My", ApartamentNumber = 1 },
                    Passport = new Passport {PassportId = new Guid("6aea979a-ccfc-44cf-82f1-777d999b384f"), BDay = 15, BMonth = 9, BYear = 1992, SeriesA = "AB", SeriesN = 888088, DayIoP = 10, YearIoP = 2010},
                    Phone = new Phone {PhoneId = new Guid("81c1562b-2e11-430c-8928-4202f12c9fa3"), mobile  = "093556", home = "556", work = "05656456"},
                    HistoryBook = new HistoryBook {HistoryBookId = new Guid("f333bbc8-b28d-4411-9363-3601ee7e3ee2"), BookNumber = 888} }
            };
        }
    }
}