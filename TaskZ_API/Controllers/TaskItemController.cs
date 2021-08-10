using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

using TaskZ_Application.Interfaces;
using TaskZ_Core.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskZ_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskItemController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<TaskItemController> _logger;

        public TaskItemController(IUnitOfWork unitOfWork, ILogger<TaskItemController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

       // GET: api/<TaskItemController>
        [HttpGet]
        public async Task<IEnumerable<TaskItem>> GetAllTaskItems()
        {
            IEnumerable<TaskItem> list = new List<TaskItem>();
            try
            {
                //throw new ArgumentException("BOOM");
                list = await _unitOfWork.TaskItems.GetAllAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Get all task items failed: {StackTrace}", ex.StackTrace);
            }
            return list;
        }

        // GET api/<TaskItemController>/5
        [HttpGet("{id}")]
        public async Task<TaskItem> GetTaskItem(int id)
        {
            return await _unitOfWork.TaskItems.GetByIdAsync(id);
        }

        // POST api/<TaskItemController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TaskItemController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TaskItemController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
