using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Outstaff.Data;
using Outstaff.DTOs;
using Outstaff.Models;

namespace Outstaff.CQ
{
    public class UpdateContractorHandler : IRequestHandler<UpdateContractorCommand, ContractorDto>
    {
        private readonly OutstaffDbContext _context;
        private readonly IMapper _mapper;

        public UpdateContractorHandler(OutstaffDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ContractorDto> Handle(UpdateContractorCommand request, CancellationToken cancellationToken)
        {
            var contractor = await _context.Contractor.FindAsync(new object[] { request.Id }, cancellationToken);
            if (contractor == null) throw new Exception("Contractor not found");

            contractor.FullName = request.FullName;
            contractor.Email = request.Email;

            await _context.SaveChangesAsync(cancellationToken);

            return _mapper.Map<ContractorDto>(contractor);
        }
    }
}
