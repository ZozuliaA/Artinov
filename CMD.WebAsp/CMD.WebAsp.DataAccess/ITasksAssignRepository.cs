using System;
using System.Collections.Generic;
using DatabaseFirst;

namespace CMD.WebAsp.DataAccess
{
    public interface ITasksAssignRepository
    {
        TaskAssign GetTaskAssignById(Guid id);
        List<TaskAssign> GetAssignedTasks(int startPosition, int recordCount);
        List<TaskAssign> GetAssignedTasksByUser(Guid userId, int startPosition, int recordCount);
        List<TaskAssign> GetAssignedTasksByStatus(int statusId, int startPosition, int recordCount);
        List<TaskAssign> GetAssignedTasksByAssignDate(DateTime date, int startPosition, int recordCount);
        List<TaskAssign> GetAssignedTasksByCloseDate(DateTime? date, int startPosition, int recordCount);
        bool AssignTask(TaskAssign taskAssign); bool DeleteAssignedTask(Guid taskAssignId);
    }
}