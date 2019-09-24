using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoSolutionsApi.Models
{
    public class DailyTask
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string nameOfDay { get; set; }
        public string priority { get; set; }
        public string remarks { get; set; }
    }
}
