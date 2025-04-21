using System;
using System.Collections.Generic;

namespace SoftDebutTest.Models;

public partial class EmployeeBackup
{
    public string EmpNum { get; set; } = null!;

    public string? EmpName { get; set; }

    public decimal? Salary { get; set; }

    public string? Position { get; set; }
}
