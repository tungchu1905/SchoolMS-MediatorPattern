using MediatR;

namespace SchoolMS.Core.Aggregration.ClassAggregration.Queries
{
    public record GetClassListQuery() : IRequest<List<InforClass>>;
}
