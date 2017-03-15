using System.Data.Entity;
using HADatabaseEntity;

namespace HospitalAppointment.DataAccess
{
    public class HaContext : DbContext
    {
        public HaContext() : base("DbConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Doctor>().HasRequired(x => x.Specialty);
            modelBuilder.Entity<Doctor>().HasRequired(x => x.DaysOfReceiving);
            modelBuilder.Entity<Doctor>().HasRequired(x => x.Specialty);


            modelBuilder.Entity<Specialty>().HasOptional(x => x.Doctors);
            modelBuilder.Entity<Specialty>().HasMany(x => x.Doctors);



            modelBuilder.Entity<DaysOfReceiving>().HasRequired(t => t.TimeOfReceiving);

            modelBuilder.Entity<Appoinment>().HasRequired(doc => doc.Doctor);
            modelBuilder.Entity<Appoinment>().HasRequired(p => p.Patient);
            modelBuilder.Entity<Appoinment>().HasRequired(r => r.Room);
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
