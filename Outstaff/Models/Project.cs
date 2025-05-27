using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outstaff.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public int ManagerId { get; set; }
        public User Manager { get; set; }

        public ICollection<Assignment> Assignment { get; set; } = new List<Assignment>();
    }
}
