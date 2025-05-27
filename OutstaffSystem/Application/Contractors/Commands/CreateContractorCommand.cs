using MediatR;
using OutstaffSystem.Models;

namespace OutstaffSystem.Application.Contractors.Commands
{
    public record CreateContractorCommand(ContractorDto Contractor) : IRequest<int>;
}