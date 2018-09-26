using System;
using System.Collections.Generic;

namespace WebApplication1.WebApplication1.Model
{
    public partial class CompanyDeptIncome
    {
        public int Id { get; set; }
        public string CompDeptName { get; set; }
        public int? SaleYtd { get; set; }
        public int? Year { get; set; }
    }
}
