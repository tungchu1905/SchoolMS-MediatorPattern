using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolMS.Core.Aggregration.ClassAggregration.Commands;
using SchoolMS.Core.Aggregration.ClassAggregration.Queries;
using SchoolMS.Core.DTO;
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

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            return Ok(await _mediator.Send(new GetClassByIdQuery(id)));
        }


        [HttpPost]
        public async Task<ActionResult> Post(CreateClassDTO createClassDTO)
        {
            var  result = await _mediator.Send(new AddClassCommand(createClassDTO));
            return Ok(result);  
        }
        [HttpPut]
        public async Task<ActionResult> Put(int id, UpdateClassDTO updateClassDTO)

        {
            var  result = await _mediator.Send(new UpdateClassCommand(id, updateClassDTO));
            return Ok(result);  
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new DeleteClassCommand(id)));
        }
    }
}
