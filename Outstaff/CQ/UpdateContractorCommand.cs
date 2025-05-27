using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Outstaff.DTOs;

namespace Outstaff.CQ
{
    public class UpdateContractorCommand : IRequest<ContractorDto>
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}
