using HelbMicroService.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelbMicroService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private IMediator _mediator;


        public ApplicationController(IMediator mediator)

        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

        }


        [HttpPost]
        public async Task<Guid> CreateCustomer([FromBody] CreateApplicationCommand command)
        {
            try
            {
                return await _mediator.Send(command);
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
