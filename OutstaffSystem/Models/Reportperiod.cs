using System;
using System.Collections.Generic;

namespace OutstaffSystem.Models;

public partial class Reportperiod
{
    public int Id { get; set; }

    public DateOnly Startdate { get; set; }

    public DateOnly Enddate { get; set; }

    public string? Description { get; set; }
}
