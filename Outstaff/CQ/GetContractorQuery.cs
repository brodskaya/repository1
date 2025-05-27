using MediatR;
using Outstaff.DTOs;
using System.Collections.Generic;

namespace Outstaff.CQ
{
    public record GetContractorQuery() : IRequest<List<ContractorDto>>;
}