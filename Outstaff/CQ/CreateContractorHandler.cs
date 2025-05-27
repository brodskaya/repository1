using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using MediatR;
using Outstaff.Data;
using Outstaff.DTOs;
using Outstaff.Models;

namespace Outstaff.CQ
{
    public class CreateContractorHandler : IRequestHandler<CreateContractorCommand, ContractorDto>
    {
        private readonly OutstaffDbContext _context;
        private readonly IMapper _mapper;

        public CreateContractorHandler(OutstaffDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ContractorDto> Handle(CreateContractorCommand request, CancellationToken cancellationToken)
        {
            var contractor = new Contractor
            {
                FullName = request.FullName,
                Email = request.Email
            };

            _context.Contractor.Add(contractor);
            await _context.SaveChangesAsync(cancellationToken);

            return _mapper.Map<ContractorDto>(contractor);
        }
    }
}
