using System;
using System.Data.Entity;
using System.Linq;
using HADatabaseEntity;

namespace HospitalAppointment.DataAccess
{
    public class DoctorRepository : BaseRepository<Doctor>
    {
        public override IQueryable<Doctor> GetAll()
        {
            var items =  Context.Doctors
                .Include(s => s.Specialty)
                .Include(t => t.DaysOfReceiving)
                .Include(t => t.DaysOfReceiving.TimeOfReceiving);
            return items;

            //запусти, щоб дойшло до цього моменту
        }

        public void AddDoctorOnContext(Doctor doc, int specialtyId)
        {
            doc.Specialty = Context.Specialties.FirstOrDefault(id => id.SpecialtyId.Equals(specialtyId));
            Context.Doctors.Add(doc);
            Context.SaveChanges();
        }

        public override void DeleteById(Guid id)
        {
            Doctor entity = GetAll().FirstOrDefault(i => i.DoctorId.Equals(id));
            DaysOfReceiving dor = Context.DaysOfReceivings.FirstOrDefault(i => i.DORId.Equals(entity.DaysOfReceiving.DORId));
            TimeOfReceiving tor = Context.TimeOfReceivings.FirstOrDefault(i => i.TORId.Equals(entity.DaysOfReceiving.TimeOfReceiving.TORId));
            Context.TimeOfReceivings.Remove(tor);
            Context.DaysOfReceivings.Remove(dor);
            Context.Doctors.Remove(entity);
            Context.SaveChanges();
        }

        /*public override void Update(Doctor entityDoctor)
        {
            Context.Entry(entityDoctor.DaysOfReceiving).State = EntityState.Modified;
            //Context.Entry(entityDoctor.DaysOfReceiving).State = EntityState.Modified;
            Context.SaveChanges();
        }*/
    }
}