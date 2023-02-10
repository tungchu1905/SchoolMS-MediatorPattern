using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolMS.Core.Aggregration.ClassAggregration.Queries;
using SchoolMS.Core.Validation;

namespace SchoolMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentClassController : ControllerBase
    {
        private IMediator _mediator;
        public StudentClassController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult> Get([FromQuery]RequestPaginate requestPaginate)
        {
            var result = await _mediator.Send(new GetClassListQuery(requestPaginate));
            return Ok(result);
        }
    }
}
