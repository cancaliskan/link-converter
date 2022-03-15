using System.Threading.Tasks;
using LinkConverter.Application.Features.ConvertedLink.Commands;
using LinkConverter.Application.Features.ConvertedLink.Queries.GetAllConvertedLinks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LinkConverter.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConverterController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ConverterController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> ConvertWebUrlToDeepLink(ConvertWebUrlToDeepLinkCommand request)
        {
            return Ok(await _mediator.Send(request));
        }
    }
}