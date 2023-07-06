using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkConverter.Application.Features.ConvertedLink.Queries.GetAllConvertedLinks;
using MediatR;

namespace LinkConverter.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConvertedLinkController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ConvertedLinkController(IMediator mediator)
        {
            this._mediator = mediator;
        }


        /// <summary>
        /// Gets the list of all converted links.
        /// </summary>
        /// <returns>The list of converted links.</returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllConvertedLinksQuery();
            return Ok(await _mediator.Send(query));
        }

    }
}
