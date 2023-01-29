using FinanceApp.Models.ENUMS;
using System.ComponentModel.DataAnnotations;

namespace FinanceApp.ViewModels
{
    public class CreateGeneralCategoryVM
    {
        public decimal ExpenseValue { get; set; }
        public DateTime ExpenseDate { get; set; }
        public string ExpenseDescription { get; set; }
        [EnumDataType(typeof(ExpenseCategories))]
        public ExpenseCategories ExpenseCategory { get; set; }
    }
}
