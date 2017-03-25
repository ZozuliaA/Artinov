using System.Data.Entity;
using System.Linq;
using HADatabaseEntity;

namespace HospitalAppointment.DataAccess
{
    public class AppointmentRepository : BaseRepository<Appoinment>
    {
        public override IQueryable<Appoinment> GetAll()
        {
            return Context.Appoinments.Include(p => p.Patient)
                .Include(d => d.Doctor)
                .Include(r => r.Room);
        }
    }
}