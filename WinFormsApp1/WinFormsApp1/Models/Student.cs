using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Addresse { get; set; }

    public int Deptid { get; set; }

    public virtual Department Dept { get; set; } = null!;
}
