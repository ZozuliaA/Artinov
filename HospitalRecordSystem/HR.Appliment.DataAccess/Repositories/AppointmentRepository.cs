using System;
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
        
        public void AddAppointmentOnContext(Guid doctorId, Guid patientId, Guid roomId, Appoinment app)
        {
            var doc = Context.Doctors.FirstOrDefault(id => id.DoctorId.Equals(doctorId));
            var pat = Context.Patients.FirstOrDefault(id => id.PatientId.Equals(patientId));
            var room = Context.Rooms.FirstOrDefault(id => id.RoomId.Equals(roomId));

            app.Doctor = doc;
            app.Patient = pat;
            app.Room = room;

            Context.Appoinments.Add(app);
            Context.SaveChanges();

        }
    }
}