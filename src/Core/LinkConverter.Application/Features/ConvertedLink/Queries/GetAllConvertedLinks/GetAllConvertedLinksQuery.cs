using System.Collections.Generic;
using LinkConverter.Application.Dtos;
using LinkConverter.Application.Wrappers;
using MediatR;

namespace LinkConverter.Application.Features.ConvertedLink.Queries.GetAllConvertedLinks
{
    public class GetAllConvertedLinksQuery : IRequest<ServiceResponse<List<ConvertedLinkDto>>>
    {
        
    }
}