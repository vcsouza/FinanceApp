using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Controllers
{
    public class ExpenseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
