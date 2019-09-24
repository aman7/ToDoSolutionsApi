using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoSolutionsApi.Models;

namespace ToDoSolutionsApi.data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {

        }
        
        public DbSet<DailyTask> dailyTasks { get; set; }
        public DbSet<ProposedTask> proposedTasks { get; set; }

    }
}
