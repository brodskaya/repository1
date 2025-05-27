using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outstaff.Models
{
    public class Rate
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public decimal HourlyRate { get; set; }
        public DateTime StartDate { get; set; }

        public int? ContractId { get; set; }
        public Contract? Contract { get; set; }

        public int? SupplementaryAgreementId { get; set; }
        public SupplementaryAgreement? SupplementaryAgreement { get; set; }
    }

}
