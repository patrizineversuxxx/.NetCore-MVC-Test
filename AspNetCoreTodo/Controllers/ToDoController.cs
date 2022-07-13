using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTodo.Controllers
{
    public class ToDoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
