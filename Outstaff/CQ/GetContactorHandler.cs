using MediatR;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Outstaff.Data;
using Outstaff.Models;
using Outstaff.DTOs;


namespace Outstaff.CQ
{
    public class GetContactorHandler : IRequestHandler<GetContractorQuery, List<ContractorDto>>
    {
        private readonly OutstaffDbContext _context;
        private readonly IMapper _mapper;

        public GetContactorHandler(OutstaffDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ContractorDto>> Handle(GetContractorQuery request, CancellationToken cancellationToken)
        {
            var contractor = await _context.Contractor.ToListAsync(cancellationToken);
            return _mapper.Map<List<ContractorDto>>(contractor);
        }
    }
}
