using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoSolutionsApi.data;
using ToDoSolutionsApi.Models;
using ToDoSolutionsApi.repository;

namespace ToDoSolutionsApi.repository
{
    public class AllTaskMethods:IAllTaskMethods
    {
        private ApplicationDBContext _context;

        
        public AllTaskMethods(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<bool> SaveChangesAsync()
        {

            // Only return success if at least one row was changed
            return (await _context.SaveChangesAsync()) > 0;
        }

        public void addDailyTask(DailyTask dailyTask)
        {
            _context.dailyTasks.Add(dailyTask);
            
        }

        public void updateDailyTask(DailyTask dailyTask)
        {
            _context.Attach(dailyTask).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            
        }

        public void deleteDailyTask(int id)
        {
            var dailytask = _context.dailyTasks.FirstOrDefault(i => i.id == id);
            _context.dailyTasks.Remove(dailytask);
            
            
        }

        public async Task<DailyTask[]> GetallDailyTaskAsync()
        {
            return await _context.dailyTasks.ToArrayAsync();
        }

        public async Task<DailyTask> GetDailyTaskByIdAsync(int id)
        {

            return await _context.dailyTasks.FirstOrDefaultAsync(i => i.id == id);
        }

        public async Task<DailyTask[]> GetAllDailyTaskByPriorityAsync(string priority)
        {
            return await _context.dailyTasks.Where(p => p.priority == priority).ToArrayAsync();
        }

        public void addProposedTask(ProposedTask proposedTask)
        {
            _context.proposedTasks.Add(proposedTask);
            _context.SaveChanges();
        }

        public void updateProposedTask(ProposedTask proposedTask)
        {
            _context.Attach(proposedTask).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public void deleteProposedTask(int id)
        {
            var proposedTask = _context.proposedTasks.FirstOrDefault(i => i.id == id);
            _context.proposedTasks.Remove(proposedTask);
        }

        public async Task<ProposedTask[]> GetallProposedTaskAsync()
        {
            return await _context.proposedTasks.ToArrayAsync();
        }

        public async Task<ProposedTask> GetAllProposedTaskByIdAsync(int id)
        {
            return await _context.proposedTasks.FirstOrDefaultAsync(i => i.id == id);
        }

        public async Task<ProposedTask[]> GetAllProposedTaskByStatusAsync(string status)
        {
            return await _context.proposedTasks.Where(s => s.status == status).ToArrayAsync();
        }

        public async Task<ProposedTask[]> GetAllProposedTaskByPriorityAsync(string priority)
        {
            return await _context.proposedTasks.Where(p => p.priority == priority).ToArrayAsync();
        }

    }
}
