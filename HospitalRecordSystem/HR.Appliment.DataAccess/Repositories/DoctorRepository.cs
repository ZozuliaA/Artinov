﻿using System.Data.Entity;
using System.Linq;
using HADatabaseEntity;

namespace HospitalAppointment.DataAccess
{
    public class DoctorRepository : BaseRepository<Doctor>
    {
        public override IQueryable<Doctor> GetAll()
        {
            return Context.Doctors.Include(d => d.DaysOfReceiving);
        }

        public void AddDoctorOnContext(Doctor doc, int specialtyId)
        {
            doc.Specialty = Context.Specialties.FirstOrDefault(id => id.SpecialtyId.Equals(specialtyId));
        }
    }
}