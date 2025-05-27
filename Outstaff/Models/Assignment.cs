using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outstaff.Models
{
    public class Assignment
    {
        public int Id { get; set; }

        public int SpecialistId { get; set; }
        public Specialist Specialist { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public decimal? HourlyRateOverride { get; set; } 
    }
}
