using MediatR;
using SchoolMS.Core.Aggregration.ClassAggregration.Queries;

namespace SchoolMS.Core.Aggregration.ClassAggregration.Handler
{
    public class GetClassByIdHandler : IRequestHandler<GetClassByIdQuery, InforClass>
    {
        public Task<InforClass> Handle(GetClassByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
