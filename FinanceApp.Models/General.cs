﻿using FinanceApp.Models.ENUMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Models
{
    public class General:Expense
    {
        public ExpenseCategories Categories { get; set; }
    }
}
