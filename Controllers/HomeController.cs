using Microsoft.AspNetCore.Mvc;

namespace TaskManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Task Management System is Running!");
        }
    }
}
