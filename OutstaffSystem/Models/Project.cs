using System;
using System.Collections.Generic;

namespace OutstaffSystem.Models;

public partial class Project
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Projectcode { get; set; }

    public virtual ICollection<Specialist> Specialists { get; set; } = new List<Specialist>();
}
