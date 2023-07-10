using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;


namespace SalesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>
            {
                new Department { Id = 1, Name = "Eletrônicos" },
                new Department { Id = 2, Name = "Fashion" }
            };


            return View(list);
        }
    }
}
