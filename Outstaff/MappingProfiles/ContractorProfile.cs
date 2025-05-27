using AutoMapper;
using Outstaff.Models;
using Outstaff.DTOs;


public class ContractorProfile : Profile
{
    public ContractorProfile()
    {
        CreateMap<Contractor, ContractorDto>();
        CreateMap<CreateContractorDto, Contractor>();
        CreateMap<UpdateContractorDto, Contractor>();
    }
}
