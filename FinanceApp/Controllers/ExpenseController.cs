using FinanceApp.dataaccess;
using FinanceApp.Models;
using FinanceApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly FinanceAppContext _context;

        public ExpenseController(FinanceAppContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Route("GeneralExpense")]
        public IActionResult General ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterGeneralExpense(CreateGeneralCategoryVM model)
        {
            General CreatedExpense = new General() 
            { Categories = model.ExpenseCategory, 
              Date=model.ExpenseDate,
              Description=model.ExpenseDescription,
              ExpenseValue=model.ExpenseValue};
            _context.Generals.Add(CreatedExpense);
            _context.SaveChanges();
            return View("~/Views/Expense/General.cshtml");
        }
    }
   
}
