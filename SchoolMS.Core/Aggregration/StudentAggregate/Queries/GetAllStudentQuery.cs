using MediatR;
using SchoolMS.Core.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.Core.Aggregration.StudentAggregate.Queries
{
    public record GetAllStudentQuery(RequestPaginate RequestPaginate) : IRequest<object>;
    
}
