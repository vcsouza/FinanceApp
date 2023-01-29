using FinanceApp.Models;

namespace FinanceApp.Models
{
    public abstract class Expense
    {
        public int ID { get; set; }
        public decimal ExpenseValue { get; set; }
        public String Description { get; set; } = null!;

        public DateTime Date { get; set; }
    }
}

