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

        public override void Insert(Patient entity)
        {
            Context.Patients.Add(entity);
            Context.SaveChanges();
        }
    }
}