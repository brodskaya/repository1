using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outstaff.Models
{
    public class Specialist
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public ICollection<Assignment> Assignment { get; set; } = new List<Assignment>();
    }
}
