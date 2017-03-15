using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using HADatabaseEntity;

namespace HospitalAppointment.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IHaService
    {
        //----Authorization
        [OperationContract]
        string GetRole(Guid patientId);
        [OperationContract]
        Patient VerefyAuth(string loggin, string password);


        //----Appointment
        [OperationContract]
        List<Appoinment> GetAppoinments();
        [OperationContract]
        List<Appoinment> GetAppoinmentsByDate(DateTime date);
        [OperationContract]
        List<Doctor> GetDoctorsBySpecialy(string specialty); // guid?

        [OperationContract]
        Patient GetPatientByAppointmentId(Guid appointmentId); // Appointment Num, Id?

        //----Patient
        [OperationContract]
        Phone GetPhoneByPatientId(Guid patientId);
        [OperationContract]
        Passport GetPassportByPatientId(Guid patientId);
        [OperationContract]
        Address GetAddressByPatientId(Guid patientId);
        [OperationContract]
        HistoryBook GetHistoryBookByPatientId(Guid patientId);

        [OperationContract]
        void InsertPatient(Patient patientEntity , string password);

        //-----Room----------------
        [OperationContract]
        void InsertRoom(Room room);
        [OperationContract]
        IQueryable<Room> GetRooms();

        //----Specialty------------
        [OperationContract]
        IQueryable<Specialty> GetSpecialties();

        [OperationContract]
        Specialty GetSpecialtyByName(string specialty);

        //-----Doctor--------------
        [OperationContract]
        IQueryable<Doctor> GetDoctors();
        [OperationContract]
        void AddDoctor(Doctor doctor);
    }
}
