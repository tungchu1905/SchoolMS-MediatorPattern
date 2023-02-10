using MediatR;
using SchoolMS.Core.Aggregration.ClassAggregration.Commands;
using SchoolMS.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.Core.Aggregration.ClassAggregration.Handler
{
    public class AddNewClassHandler : IRequestHandler<AddClassCommand, object>
    {
        private IClassService _service;
        public AddNewClassHandler(IClassService service)
        {
            _service = service;
        }
        public async Task<object> Handle(AddClassCommand request, CancellationToken cancellationToken)
        {
            var result = await _service.CraeteClass(request.CreateClassDTO);
            return result;
        }
    }
}
