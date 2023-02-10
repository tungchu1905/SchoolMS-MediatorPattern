using MediatR;
using SchoolMS.Core.Aggregration.ClassAggregration;
using SchoolMS.Core.Aggregration.ClassAggregration.Queries;
using SchoolMS.Core.Repository.Repositories.Interfaces;

namespace SchoolMS.Core.Aggregration.ClassAggregration.Handler
{
    public class GetClassListHandler : IRequestHandler<GetClassListQuery, List<InforClass>>
    {
        private readonly IClassInforRepository _classRepository;
        public GetClassListHandler(IClassInforRepository classRepository)
        {
            _classRepository = classRepository;
        }
        public async Task<List<InforClass>> Handle(GetClassListQuery request, CancellationToken cancellationToken)
        {
            var result = await _classRepository.GetAll();
            return (List<InforClass>)result;
        }
    }
}
