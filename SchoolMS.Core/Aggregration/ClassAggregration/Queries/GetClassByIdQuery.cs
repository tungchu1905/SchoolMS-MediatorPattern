using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.Core.Aggregration.ClassAggregration.Queries
{
    public record GetClassByIdQuery(int id) : IRequest<object>;
}
