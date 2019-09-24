using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoSolutionsApi.Models;

namespace ToDoSolutionsApi.repository
{
    public interface IAllTaskMethods
    {

        Task<bool> SaveChangesAsync();
        Task<ProposedTask[]> GetallProposedTaskAsync();
        Task<ProposedTask[]> GetAllProposedTaskByStatusAsync(string status);
        Task<ProposedTask[]> GetAllProposedTaskByPriorityAsync(string priority);
        Task<ProposedTask> GetAllProposedTaskByIdAsync(int id);
        void addProposedTask(ProposedTask proposedTask);
        void updateProposedTask(ProposedTask proposedTask);
        void deleteProposedTask(int id);

        Task<DailyTask[]> GetallDailyTaskAsync();
        Task<DailyTask[]> GetAllDailyTaskByPriorityAsync(string priority);
        Task<DailyTask> GetDailyTaskByIdAsync(int id);
        void addDailyTask(DailyTask dailyTask);
        void updateDailyTask(DailyTask dailyTask);
        void deleteDailyTask(int id);

    }
}
