using MediatR;
using OutstaffSystem.Models;

namespace OutstaffSystem.Application.Contractors.Commands
{
    public class EditContractorCommand : IRequest<Unit>  // ← ОБЯЗАТЕЛЬНО Unit
    {
        public ContractorDto Contractor { get; }

        public EditContractorCommand(ContractorDto contractor)
        {
            Contractor = contractor;
        }
    }
}