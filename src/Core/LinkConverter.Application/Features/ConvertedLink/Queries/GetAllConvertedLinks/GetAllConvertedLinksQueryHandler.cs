using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LinkConverter.Application.Dtos;
using LinkConverter.Application.Interfaces.Repositories;
using LinkConverter.Application.Wrappers;
using MediatR;

namespace LinkConverter.Application.Features.ConvertedLink.Queries.GetAllConvertedLinks
{
    public class GetAllConvertedLinksQueryHandler : IRequestHandler<GetAllConvertedLinksQuery, ServiceResponse<List<ConvertedLinkDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllConvertedLinksQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<ConvertedLinkDto>>> Handle(GetAllConvertedLinksQuery request, CancellationToken cancellationToken)
        {
            var convertedLinks = await _unitOfWork.ConvertedLinks.GetAllAsync();
            var dtos = _mapper.Map<List<ConvertedLinkDto>>(convertedLinks);
            return new ServiceResponse<List<ConvertedLinkDto>>(dtos);
        }
    }
}