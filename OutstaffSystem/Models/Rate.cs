using System;
using System.Collections.Generic;

namespace OutstaffSystem.Models;

public partial class Rate
{
    public int Id { get; set; }

    public int Agreementid { get; set; }

    public string Position { get; set; } = null!;

    public decimal Hourlyrate { get; set; }

    public DateOnly Startdate { get; set; }

    public DateOnly? Enddate { get; set; }

    public virtual Agreement Agreement { get; set; } = null!;

    public virtual ICollection<Specialist> Specialists { get; set; } = new List<Specialist>();
}
