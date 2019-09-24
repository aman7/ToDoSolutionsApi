using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoSolutionsApi.Models
{
    public class ProposedTask
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string titleLink { get; set; }

        public string priority { get; set; }
        public string status { get; set; } = "pending";
        public string remarks { get; set; }
    }
}
