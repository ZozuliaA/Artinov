using System;
using System.Data.Entity;
using System.Linq;
using HADatabaseEntity;

namespace HospitalAppointment.DataAccess
{
    public class DorRepository : BaseRepository<DaysOfReceiving>
    {
        public override IQueryable<DaysOfReceiving> GetAll()
        {
            return Context.DaysOfReceivings.Include(t => t.TimeOfReceiving);
        }

        
    }
}