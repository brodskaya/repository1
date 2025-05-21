using System;
using System.Collections.Generic;

namespace OutstaffSystem.Models;

public partial class Agreement
{
    public int Id { get; set; }

    public int Contractid { get; set; }

    public DateOnly Agreementdate { get; set; }

    public virtual Contract Contract { get; set; } = null!;

    public virtual ICollection<Rate> Rates { get; set; } = new List<Rate>();
}
