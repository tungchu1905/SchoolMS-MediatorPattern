using MediatR;
using SchoolMS.Core.Aggregration.StudentAggregate.Queries;
using SchoolMS.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.Core.Aggregration.StudentAggregate.Handler
{
    public class GetAllStudentHandler : IRequestHandler<GetAllStudentQuery, object>
    { 
        private readonly IStudentService _sevice;
        public GetAllStudentHandler(IStudentService sevice)
        {
            _sevice = sevice;
        }
        public async Task<object> Handle(GetAllStudentQuery request, CancellationToken cancellationToken)
        {
            var result = await _sevice.GetStudentPagedList(request.RequestPaginate);
            return result;
        }
    }
}
