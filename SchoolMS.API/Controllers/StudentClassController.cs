using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolMS.Core.Aggregration.ClassAggregration.Queries;

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
        public async Task<ActionResult> Get()
        {
            var result = await _mediator.Send(new GetClassListQuery());
            return Ok(result);
        }
    }
}
