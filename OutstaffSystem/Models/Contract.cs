using System;
using System.Collections.Generic;

namespace OutstaffSystem.Models;

public partial class Contract
{
    public int Id { get; set; }

    public int Contractorid { get; set; }

    public string Contractnumber { get; set; } = null!;

    public DateOnly Contractdate { get; set; }

    public virtual ICollection<Agreement> Agreements { get; set; } = new List<Agreement>();

    public virtual Contractor Contractor { get; set; } = null!;
}
