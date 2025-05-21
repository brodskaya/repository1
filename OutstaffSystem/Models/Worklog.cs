using System;
using System.Collections.Generic;

namespace OutstaffSystem.Models;

public partial class Worklog
{
    public int Id { get; set; }

    public int Specialistid { get; set; }

    public DateOnly Workdate { get; set; }

    public decimal Hoursworked { get; set; }

    public string? Taskdescription { get; set; }

    public virtual Specialist Specialist { get; set; } = null!;
}
