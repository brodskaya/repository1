using MediatR;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OutstaffSystem.Data;
using OutstaffSystem.Models;
using System.Threading;
using System.Threading.Tasks;

namespace OutstaffSystem.Application.Contractors.Commands
{
    public class EditContractorHandler : IRequestHandler<EditContractorCommand, Unit>
    {
        private readonly OutstaffContext _context;
        private readonly IMapper _mapper;

        public EditContractorHandler(OutstaffContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(EditContractorCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Contractors.FirstOrDefaultAsync(x => x.Id == request.Contractor.Id);
            if (entity == null) throw new System.Exception("Контрагент не найден");

            _mapper.Map(request.Contractor, entity);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}