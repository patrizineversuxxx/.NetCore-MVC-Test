using AspNetCoreTodo.Models;
using AspNetCoreTodo.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTodo.Controllers
{
    public class ToDoController : Controller
    {

        private readonly ITodoItemService _todoItemService;

        public ToDoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        public async Task<IActionResult> Index()
        {
            var items = await _todoItemService.GetIncompleteItemsAsync();
            var model = new TodoViewModel()
            {
                Items = items
            };

            return View(model);
        }
    }
}
