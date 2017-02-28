﻿using System.Data.Entity;
using HADatabaseEntity;

namespace HospitalAppointment.DataAccess
{
    public class HaContext : DbContext
    {
        public HaContext() : base("DbConnection")
        {

        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Appoinment> Appoinments { get; set; }
        public DbSet<DaysOfReceiving> DaysOfReceivings { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<HistoryBook> HistoryBooks { get; set; }
        public DbSet<Passport> Passports { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<TimeOfReceiving> TimeOfReceivings { get; set; }
    }
}
