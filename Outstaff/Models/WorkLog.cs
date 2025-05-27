using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outstaff.Models
{
    public class WorkLog
    {
        public int Id { get; set; }

        public int AssignmentId { get; set; }
        public Assignment Assignment { get; set; }

        public DateTime Date { get; set; }
        public decimal Hours { get; set; }

        public string? TaskName { get; set; }
        public string? TaskSystem { get; set; } 
    }
}
