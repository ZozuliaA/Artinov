using System;
using System.Collections.Generic;
using System.ServiceModel;
using HADatabaseEntity;

namespace HospitalAppointment.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IHaService
    {
        [OperationContract]
        List<Appoinment> GetAppoinments();
        [OperationContract]
        List<Appoinment> GetAppoinmentsByDate(DateTime date);
        [OperationContract]
        List<Doctor> GetDoctorsBySpecialy(string specialty); // guid?

        [OperationContract]
        Patient GetPatientByAppointmentId(Guid appointmentId); // Appointment Num, Id?
        [OperationContract]
        Phone GetPhoneByPatientId(Guid patientId);
        [OperationContract]
        Passport GetPassportByPatientId(Guid patientId);
        [OperationContract]
        Address GetAddressByPatientId(Guid patientId);
        [OperationContract]
        HistoryBook GetHistoryBookByPatientId(Guid patientId); 

    }
}
