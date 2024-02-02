using AbsaBankMicroservice.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AbsaBankMicroservice.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAccountController : ControllerBase
    {
        private readonly IMediator _mediator;
        public StudentAccountController(IMediator mediator)
        {
            _mediator =mediator?? throw new ArgumentNullException(nameof(mediator));    
        }
        //// GET: api/<StudentAccountController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<StudentAccountController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<StudentAccountController>
        [HttpPost]
        public async Task<Guid> CreateStudentAccount([FromBody] CreateStudentAccountCommand command)
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

        //// PUT api/<StudentAccountController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<StudentAccountController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
