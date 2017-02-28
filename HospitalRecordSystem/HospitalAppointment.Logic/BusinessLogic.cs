using HospitalAppointment.DataAccess;

//using HospitalAppointment.DataAccess;

namespace HospitalAppointment.Logic
{
    public class BusinessLogic<T> where T: class 
    {
        protected readonly BaseRepository<T> Repository; 

        public BusinessLogic(HaContext context)
        {
            Repository = new BaseRepository<T>();
        }
        
    }
}
