using MediatR;
using SchoolMS.Core.Validation;

namespace SchoolMS.Core.Aggregration.ClassAggregration.Queries
{
    public record GetClassListQuery(RequestPaginate RequestPaginate) : IRequest<object>;
}
