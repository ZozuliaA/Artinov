using System;
using System.Collections.Generic;
using DatabaseFirst;

namespace CMD.WebAsp.DataAccess
{
    public interface ITasksRepository
    {
        Task GetTaskById(Guid id);
        List<Task> GetAllTasks(int startPosition, int recordCount);
        //List<Task> GetTasksByPrioriryType(PriorityType priorityType, int startPosition, int recordCount);
        List<Task> GetTaskByStatusType(int statusTypeId, int startPosition, int recordCount);
        bool DeleteTasks(List<Task> tasks);
        bool UpsertTask(Task task);
        bool DeleteTaskById(Guid id);
    }
}