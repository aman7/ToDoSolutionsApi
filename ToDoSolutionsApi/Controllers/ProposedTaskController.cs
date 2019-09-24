using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoSolutionsApi.Models;
using ToDoSolutionsApi.repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoSolutionsApi.Controllers
{
    [Route("api/[controller]")]
    public class ProposedTaskController : ControllerBase
    {
        private readonly IAllTaskMethods _allTaskMethods;

        public ProposedTaskController(IAllTaskMethods allTaskMethods)
        {
            _allTaskMethods = allTaskMethods;
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<ProposedTask[]>> Get()
        {
            return await _allTaskMethods.GetallProposedTaskAsync();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProposedTask>> Get(int id)
        {
            return await _allTaskMethods.GetAllProposedTaskByIdAsync(id);
        }

        // GET api/<controller>/priority?priority=normal
        [HttpGet("priority")]
        public async Task<ActionResult<ProposedTask[]>> priority(string priority)
        {

            return await _allTaskMethods.GetAllProposedTaskByPriorityAsync(priority);
        }

        // GET api/<controller>/status?status=pending
        [HttpGet("status")]
        public async Task<ActionResult<ProposedTask[]>> status(string status)
        {

            return await _allTaskMethods.GetAllProposedTaskByStatusAsync(status);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<ActionResult<ProposedTask>> Post([FromBody]ProposedTask proposedTask)
        {
            _allTaskMethods.addProposedTask(proposedTask);
            if(await _allTaskMethods.SaveChangesAsync())
            {
                return Ok();
            }
            return BadRequest();
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<ProposedTask>> Put(int id, [FromBody]ProposedTask proposedTask)
        {
            if (id != proposedTask.id)
                return NotFound();
            if (proposedTask != null)
            {
                _allTaskMethods.updateProposedTask(proposedTask);
                if (await _allTaskMethods.SaveChangesAsync())
                {
                    return Ok();
                }
                return BadRequest(proposedTask);
            }
            return BadRequest();
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var data = _allTaskMethods.GetAllProposedTaskByIdAsync(id);
            if (data == null)
                return NotFound();
            _allTaskMethods.deleteProposedTask(id);
            if(await _allTaskMethods.SaveChangesAsync())
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
