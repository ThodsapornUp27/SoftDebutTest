using System;
using System.Collections.Generic;

namespace SoftDebutTest.Models;

public partial class Department
{
    public string DepNo { get; set; } = null!;

    public string? DepName { get; set; }

    public string? Location { get; set; }
}
