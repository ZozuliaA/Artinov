using System;
using HADatabaseEntity;
using HospitalAppointment.DataAccess;

namespace HospitalAppointment.Logic
{
    public class AppointmentBusinessLogic : BusinessLogic<Appoinment, AppointmentRepository>
    {
        public void AddAppointmentOnContext(Guid doctorId, Guid patientId, Guid roomId, Appoinment app)
        {
            Repository.AddAppointmentOnContext(doctorId, patientId, roomId, app);
        }
    }
}