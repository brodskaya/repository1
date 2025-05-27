using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OutstaffSystem.Data;
using OutstaffSystem.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OutstaffSystem.Application.Contractors.Queries
{
    public class GetAllContractorsHandler : IRequestHandler<GetAllContractorsQuery, List<ContractorDto>>
    {
        private readonly OutstaffContext _context;
        private readonly IMapper _mapper;

        public GetAllContractorsHandler(OutstaffContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ContractorDto>> Handle(GetAllContractorsQuery request, CancellationToken cancellationToken)
        {
            var contractors = await _context.Contractors.ToListAsync(cancellationToken);
            return _mapper.Map<List<ContractorDto>>(contractors);
        }
    }
}