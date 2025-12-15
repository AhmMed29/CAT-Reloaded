using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api_TaskManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        public static List<TodoTask> tasks = new List<TodoTask>();

        [HttpPost]
        public IActionResult AddTask(TodoTask task)
        {
            tasks.Add(task);
            return Ok(task); 
        }

        [HttpGet]
        public IActionResult GetAllTasks()
        {
            return Ok(tasks);
        }

        [HttpPut("{id}")]
        public IActionResult EditTask(TodoTask task)
        {
            var existingTask = tasks.FirstOrDefault(t=>t.ID == task.ID);
            if (existingTask == null)
            {
                return NotFound();
            }
            existingTask.title = task.title;
            existingTask.status = task.status;
            existingTask.priority = task.priority;
            existingTask.description = task.description;

            return Ok(existingTask);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            var existingTask = tasks.FirstOrDefault(t => t.ID == id);
            if (existingTask == null)
            {
                return NotFound();
            }
            tasks.Remove(existingTask);
            return Ok(existingTask);
        }
    }
}
