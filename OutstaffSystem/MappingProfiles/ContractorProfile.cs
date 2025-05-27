using AutoMapper;
using OutstaffSystem.Models;

namespace OutstaffSystem.MappingProfiles
{
    public class ContractorProfile : Profile
    {
        public ContractorProfile()
        {
            CreateMap<Contractor, ContractorDto>().ReverseMap();
        }
    }
}