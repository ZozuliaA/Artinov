using System.Collections.Generic;
using DatabaseFirst;

namespace CMD.WebAsp.DataAccess
{
    public interface IStatusesRepository
    {
        List<Status> GetAllStatuses();
        List<Status> GetStatusesByStatusType(int statusTypeId);
        bool AddStatus(Status status);
        bool DeleteStatus(int statusId);
    }
}