using System;
using System.Data.Entity;
using System.Linq;
using HADatabaseEntity;

namespace HospitalAppointment.DataAccess
{
    public class PatientRepository : BaseRepository<Patient>
    {
        public override IQueryable<Patient> GetAll()
        {
            return Context.Patients.Include(p => p.Phone)
                .Include(p => p.Passport)
                .Include(a => a.Address)
                .Include(h => h.HistoryBook);
        }

        public override void DeleteById(Guid id)
        {
            Patient entity = GetAll().FirstOrDefault(i => i.PatientId.Equals(id));
            Passport passport = Context.Passports.FirstOrDefault(i => i.PassportId.Equals(entity.Passport.PassportId));//&&&????
            Context.Passports.Remove(passport);
            //entity.Passport = passport;
            Address address = Context.Addresses.FirstOrDefault(i => i.AddressId.Equals(entity.Address.AddressId));
            Context.Addresses.Remove(address);
            Phone phone = Context.Phones.FirstOrDefault(i => i.PhoneId.Equals(entity.Phone.PhoneId));
            Context.Phones.Remove(phone);
            HistoryBook historyBook =Context.HistoryBooks.FirstOrDefault(i => i.HistoryBookId.Equals(entity.HistoryBook.HistoryBookId));
            Context.HistoryBooks.Remove(historyBook);
            /*entity.Address = address;
            entity.Phone = phone;
            entity.HistoryBook = historyBook;*/
            Context.Patients.Remove(entity);
            Context.SaveChanges();
        }

        public override void Insert(Patient entity)
        {
            Context.Patients.Add(entity);
            Context.SaveChanges();
        }
    }
}