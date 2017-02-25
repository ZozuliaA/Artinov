using System.Data.Entity;

namespace HospitalAppointment.DataAccess
{
    public class HaContext : DbContext
    {
        public HaContext() : base("dbconnection")
        {

        }


    }
}
