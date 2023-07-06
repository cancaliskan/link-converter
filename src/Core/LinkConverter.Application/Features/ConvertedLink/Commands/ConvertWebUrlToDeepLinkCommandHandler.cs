using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LinkConverter.Application.Factories;
using LinkConverter.Application.Interfaces.Repositories;
using LinkConverter.Application.Wrappers;
using MediatR;

namespace LinkConverter.Application.Features.ConvertedLink.Commands
{
    public class ConvertWebUrlToDeepLinkCommandHandler : IRequestHandler<ConvertWebUrlToDeepLinkCommand, ServiceResponse<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ConvertWebUrlToDeepLinkCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<string>> Handle(ConvertWebUrlToDeepLinkCommand request, CancellationToken cancellationToken)
        {
            var response = new ServiceResponse<string>(null);

            var existEntity = _unitOfWork.ConvertedLinks.Find(convertedLink => convertedLink.WebUrl == request.Link).FirstOrDefault();
            if (existEntity != null)
            {
                response.Value = existEntity.DeepLink;
                return response;
            }

            var result = LinkConverterFactory.GetConvertedLink(request.Link);
            response.Value = result;

            await SaveToDb(request, result);

            return response;
        }

        private async Task SaveToDb(ConvertWebUrlToDeepLinkCommand request, string result)
        {
            var convertedLink = new Domain.Entities.ConvertedLink()
            {
                WebUrl = request.Link,
                DeepLink = result
            };
            await _unitOfWork.ConvertedLinks.AddAsync(convertedLink);
            await _unitOfWork.CommitAsync();
        }
    }
}