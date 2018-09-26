using System;
using System.Collections.Generic;

namespace WebApiApp.Models
{
    public partial class OrgEmployye
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string ManagerId { get; set; }
    }
}
