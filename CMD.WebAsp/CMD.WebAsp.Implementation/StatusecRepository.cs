using System;
using System.Collections.Generic;
using CMD.WebAsp.DataAccess;
using DatabaseFirst;

namespace CMD.WebAsp.Implementation
{
    public class StatusecRepository : IStatusesRepository
    {
        public List<Status> GetAllStatuses()
        {
            throw new NotImplementedException();
        }

        public List<Status> GetStatusesByStatusType(int statusTypeId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteStatus(int statusId)
        {
            throw new NotImplementedException();
        }

        public bool AddStatus(Status status)
        {
            throw new NotImplementedException();
        }
    }
}
