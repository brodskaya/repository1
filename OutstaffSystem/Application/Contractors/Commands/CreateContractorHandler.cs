using AutoMapper;
using MediatR;
using OutstaffSystem.Data;
using OutstaffSystem.Models;
using System.Threading;
using System.Threading.Tasks;

namespace OutstaffSystem.Application.Contractors.Commands
{
    public class CreateContractorHandler : IRequestHandler<CreateContractorCommand, int>
    {
        private readonly OutstaffContext _context;
        private readonly IMapper _mapper;

        public CreateContractorHandler(OutstaffContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateContractorCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Contractor>(request.Contractor);
            _context.Contractors.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }
    }
}