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
        IQueryable<Appoinment> GetAppoinments();
        [OperationContract]
        IQueryable<Appoinment> GetAppoinmentsByDate(DateTime date);
        [OperationContract]
        IQueryable<Appoinment> GetAppoinmentsByPatientId(Guid patientId);

        [OperationContract]
        void AddAppointment(Appoinment appoinment);

        [OperationContract]
        void DeleteAppointmentById(Guid appoinmentId);






        //----Patient
        [OperationContract]
        Patient GetPatientByAppointmentId(Guid appointmentId);
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

        [OperationContract]
        int GetSpecialtyIdByName(string specialty);

        //-----Doctor--------------
        [OperationContract]
        IQueryable<Doctor> GetDoctors();
        [OperationContract]
        Doctor GetDoctorById(Guid doctoId);
        [OperationContract]
        void AddDoctor(Doctor doctor);

        [OperationContract]
        void AddDoctorOnContext(Doctor doc, int spesialtyId);

        [OperationContract]
        IQueryable<Doctor> GetDoctorsBySpecialy(int specialty);

        //-----
    }
}
