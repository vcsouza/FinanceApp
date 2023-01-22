namespace FinanceApp.Models
{
    public abstract class Expense
    {
        public int id { get; set; }
        public double expenseValue { get; set; }
        public String description { get; set; }

        public DateTime date { get; set; }
    }
}