using System;
using System.Collections.Generic;
using HADatabaseEntity;

namespace HospitalAppointment.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HrService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HrService.svc or HrService.svc.cs at the Solution Explorer and start debugging.
    public class HaService : IHaService
    {
        public List<Appoinment> GetAppoinments()
        {
            throw new NotImplementedException();
        }

        public List<Appoinment> GetAppoinmentsByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<Doctor> GetDoctorsBySpecialy(string specialty)
        {
            throw new NotImplementedException();
        }

        public Patient GetPatientByAppointmentId(Guid appointmentId)
        {
            throw new NotImplementedException();
        }

        public Phone GetPhoneByPatientId(Guid patientId)
        {
            throw new NotImplementedException();
        }

        public Passport GetPassportByPatientId(Guid patientId)
        {
            throw new NotImplementedException();
        }

        public Address GetAddressByPatientId(Guid patientId)
        {
            throw new NotImplementedException();
        }

        public HistoryBook GetHistoryBookByPatientId(Guid patientId)
        {
            throw new NotImplementedException();
        }
    }
}
