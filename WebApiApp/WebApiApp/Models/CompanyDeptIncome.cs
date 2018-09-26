using System;
using System.Collections.Generic;

namespace WebApiApp.Models
{
    public partial class CompanyDeptIncome
    {
        public int Id { get; set; }
        public string CompDeptName { get; set; }
        public int? SaleYtd { get; set; }
        public int? Year { get; set; }
    }
}
