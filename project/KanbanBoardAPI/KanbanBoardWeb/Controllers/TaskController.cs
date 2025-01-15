using KanbanBoardWeb.Models;
using KanbanBoardWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Task = KanbanBoardWeb.Models.Task;

namespace KanbanBoardWeb.Controllers
{
    public class TaskController : Controller
    {
        private readonly TaskService _taskService;

        public TaskController(TaskService taskService)
        {
            _taskService = taskService;
        }

        public async Task<IActionResult> Index()
        {
            var tasks = await _taskService.GetTasksAsync();
            return View(tasks);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Task task)
        {
            if (ModelState.IsValid)
            {
                await _taskService.CreateTaskAsync(task);
                return RedirectToAction("Index");
            }
            return View(task);
        }
    }
}
