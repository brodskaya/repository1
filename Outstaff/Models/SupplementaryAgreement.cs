using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Outstaff.Models
{
    public class SupplementaryAgreement
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }

        public int ContractId { get; set; }
        public Contract Contract { get; set; }

        public ICollection<Rate> Rate { get; set; } = new List<Rate>();
    }
}
