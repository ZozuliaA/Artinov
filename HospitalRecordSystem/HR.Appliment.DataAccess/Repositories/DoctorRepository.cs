using System.Data.Entity;
using System.Linq;
using HADatabaseEntity;

namespace HospitalAppointment.DataAccess
{
    public class DoctorRepository : BaseRepository<Doctor>
    {
        public override IQueryable<Doctor> GetAll()
        {
            return Context.Doctors.Include(t => t.DaysOfReceiving.TimeOfReceiving);
        }

        public void AddDoctorOnContext(Doctor doc, int specialtyId)
        {
            doc.Specialty = Context.Specialties.FirstOrDefault(id => id.SpecialtyId.Equals(specialtyId));
            Context.Doctors.Add(doc);
            Context.SaveChanges();
        }
    }
}