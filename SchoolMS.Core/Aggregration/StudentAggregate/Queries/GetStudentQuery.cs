using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.Core.Aggregration.StudentAggregate.Queries
{
    public  record GetStudentQuery(int id) : IRequest<object>;
}
