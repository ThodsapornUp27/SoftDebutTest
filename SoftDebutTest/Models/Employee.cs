using System;
using System.Collections.Generic;

namespace SoftDebutTest.Models;

public partial class Employee
{
    public string EmpNum { get; set; } = null!;

    public string? EmpName { get; set; }

    public DateOnly? HireDate { get; set; }

    public decimal? Salary { get; set; }

    public string? Position { get; set; }

    public string? DepNo { get; set; }

    public string? HeadNo { get; set; }
}
