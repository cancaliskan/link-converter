using LinkConverter.Application.Dtos;
using MediatR;

using LinkConverter.Application.Wrappers;

namespace LinkConverter.Application.Features.ConvertedLink.Commands
{
    public class ConvertWebUrlToDeepLinkCommand : IRequest<ServiceResponse<string>>
    {
        public string Link { get; set; }
    }
}