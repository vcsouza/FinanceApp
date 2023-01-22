using FinanceApp.Models.ENUMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Models
{
    public class Enterteinment:Expense
    {
        public EnterteinmentCategories Categories { get; set; }
    }
}
