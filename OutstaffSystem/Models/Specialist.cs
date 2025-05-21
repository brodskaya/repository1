using System;
using System.Collections.Generic;

namespace OutstaffSystem.Models;

public partial class Specialist
{
    public int Id { get; set; }

    public string Fullname { get; set; } = null!;

    public int Contractorid { get; set; }

    public int? Projectid { get; set; }

    public int? Currentrateid { get; set; }

    public string? Employmenttype { get; set; }

    public DateOnly? Workagreementend { get; set; }

    public virtual Contractor Contractor { get; set; } = null!;

    public virtual Rate? Currentrate { get; set; }

    public virtual Project? Project { get; set; }

    public virtual ICollection<Worklog> Worklogs { get; set; } = new List<Worklog>();
}
