using MediatR;
using SchoolMS.Core.Aggregration.ClassAggregration.Queries;
using SchoolMS.Core.Repository.Repositories.Interfaces;
using SchoolMS.Core.Services.Interfaces;

namespace SchoolMS.Core.Aggregration.ClassAggregration.Handler
{
    public class GetClassListHandler : IRequestHandler<GetClassListQuery, object>
    {
        private readonly IClassService _classService;
        public GetClassListHandler(IClassService classService)
        {
            _classService = classService;
        }
        public async Task<object> Handle(GetClassListQuery request, CancellationToken cancellationToken)
        {
            var result = await _classService.GetClassPagedList(request.RequestPaginate);
            return result;
        }
    }
}
