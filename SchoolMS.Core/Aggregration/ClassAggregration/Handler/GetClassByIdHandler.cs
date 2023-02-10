using MediatR;
using SchoolMS.Core.Aggregration.ClassAggregration.Queries;
using SchoolMS.Core.Services.Interfaces;

namespace SchoolMS.Core.Aggregration.ClassAggregration.Handler
{
    public class GetClassByIdHandler : IRequestHandler<GetClassByIdQuery, object>
    {
        private readonly IClassService _service;
        public GetClassByIdHandler(IClassService classService)
        {
            _service = classService;
        }
        public async Task<object> Handle(GetClassByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _service.GetDetailClass(request.id);
            return result;
        }
    }
}
