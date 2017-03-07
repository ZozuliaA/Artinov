using System;
using System.Collections.Generic;
using DatabaseFirst;

namespace CMD.WebAsp.DataAccess
{
    public interface  ITaskUsersRepository
    {
        TaskUser GetUserBuId(Guid userId);
        List<TaskUser> GetAllUsers();
        bool AddTaskUser(TaskUser taskUser);
        bool DeleteUser(Guid taskUserId);
    }
}