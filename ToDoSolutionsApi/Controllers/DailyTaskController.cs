using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ToDoSolutionsApi.Models;
using ToDoSolutionsApi.repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoSolutionsApi.Controllers
{
    [Route("api/[controller]")]
    public class DailyTaskController : ControllerBase
    {
        private readonly IAllTaskMethods _allTaskMethods;
        private IMapper _mapper;

        public DailyTaskController(IAllTaskMethods allTaskMethods, IMapper mapper)
        {
            _allTaskMethods = allTaskMethods;
            _mapper = mapper;
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<DailyTask[]>> Get()
        {
            return await _allTaskMethods.GetallDailyTaskAsync();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DailyTask>> Get(int id)
        {
            return await _allTaskMethods.GetDailyTaskByIdAsync(id);
        }

        // GET api/<controller>/priority?priority=normal
        [HttpGet("priority")]
        public async Task<ActionResult<DailyTask[]>> priority(string priority)
        {
            
            return await _allTaskMethods.GetAllDailyTaskByPriorityAsync(priority);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<string> Post([FromBody]DailyTask dailyTask)
        {
            if (dailyTask != null)
            {
                _allTaskMethods.addDailyTask(dailyTask);
                if(await _allTaskMethods.SaveChangesAsync())
                {
                    return "Record Added";
                }
                return "Couldnt add Record";
            }
            
            return "Not Ok";
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<DailyTask>> Put(int id, [FromBody]DailyTask dailyTask)
        {
            //var oldData = await _allTaskMethods.GetDailyTaskByIdAsync(id);
            if (id != dailyTask.id)
            {
                return NotFound();
            }
            
            if (dailyTask != null)
            {
                 _allTaskMethods.updateDailyTask(dailyTask);
                if(await _allTaskMethods.SaveChangesAsync())
                {
                    return Ok();
                }
                return BadRequest(dailyTask);
            }
            return BadRequest();

        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var data = await _allTaskMethods.GetDailyTaskByIdAsync(id);
            if (data == null)
                return NotFound();
            _allTaskMethods.deleteDailyTask(id);
            if(await _allTaskMethods.SaveChangesAsync())
            {
                return Ok();
            }
            return BadRequest();

        }
    }
}
