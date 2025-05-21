using System;
using System.Collections.Generic;

namespace OutstaffSystem.Models;

public partial class Contractor
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual ICollection<Specialist> Specialists { get; set; } = new List<Specialist>();
}
