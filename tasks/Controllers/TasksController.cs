using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using tasks.Model;
using tasks.Services;

namespace tasks.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly ILogger<TasksController> _logger;
        private readonly IStorageService _storage;

        public TasksController(ILogger<TasksController> logger, IStorageService storage)
        {
            _logger = logger;
            _storage = storage;
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        public IActionResult CreateTask([FromBody]NewTask newTask)
        {
            return Ok(newTask);
        }

        [HttpGet]
        public IActionResult QueryTasks([FromQuery]TaskQuery query)
        // public IActionResult QueryTasks([FromQuery]string title, [FromQuery]string id)
        {
            return Ok(query);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> QueryTasks([FromBody] Guid id)
        {
            var task = await _storage.GetTasksAsync(id: id);
            if (task.Any())
            {
                return Ok(task);
            }
            return NotFound("No tasks exists");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTask([FromBody] Entity.Task task)
        {
            var tasks = await _storage.UpdateTaskAsync(task);
            if (!tasks.IsSuccess)
            {
                return NotFound($"Task with ID {task.Id} not found");
            }
            return Ok(tasks);
        }

        // [HttpDelete]
        // [Route("{id}")]
        // public async Task<IActionResult> DeleteTask([FromRoute] Entity.Task task)
        // {
        //     try
        //     {
        //         await _storage..RemoveTaskAsync(task);
        //         await _storage.SaveChangesAsync();
        //         _logger.LogInformation($"Task deleted {task.Id}");
        //         return Ok("Task deleted");
        //     }
        //     catch(Exception e)
        //     {
        //         _logger.LogInformation($"Task with ID: {task.Id} not deleted");
        //         return InternalServerError($"Error: {e.Message}");
        //     }
        // }

    }
}