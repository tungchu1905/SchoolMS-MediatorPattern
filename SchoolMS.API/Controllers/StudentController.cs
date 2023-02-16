using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolMS.Core.Aggregration.StudentAggregate.Queries;
using SchoolMS.Core.Validation;

namespace SchoolMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly  IMediator _mediator;
        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll([FromQuery]RequestPaginate requestPaginate)
        {
            var result  = await _mediator.Send(new GetAllStudentQuery(requestPaginate));
            return Ok(result);
        }
    }
}
