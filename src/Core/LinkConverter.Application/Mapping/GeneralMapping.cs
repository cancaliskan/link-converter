using AutoMapper;

namespace LinkConverter.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Domain.Entities.ConvertedLink, Dtos.ConvertedLinkDto>()
                .ReverseMap();
        }
    }
}