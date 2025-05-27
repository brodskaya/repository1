using MediatR;
using OutstaffSystem.Models;
using System.Collections.Generic;

namespace OutstaffSystem.Application.Contractors.Queries
{
    public record GetAllContractorsQuery : IRequest<List<ContractorDto>>;
}