using HADatabaseEntity;
using HospitalAppointment.DataAccess;

namespace HospitalAppointment.Logic
{
    public class DoctorBusinessLogic : BusinessLogic<Doctor, DoctorRepository>
    {
        public void AddDoctorOnContext(Doctor doc, int specialtyId)
        {
            Repository.AddDoctorOnContext(doc, specialtyId);
        }

    }
}