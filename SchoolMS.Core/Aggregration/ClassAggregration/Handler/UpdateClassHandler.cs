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
    public class UpdateClassHandler : IRequestHandler<UpdateClassCommand, object>
    {
        private IClassService _service;
        public UpdateClassHandler(IClassService service)
        {
                _service = service;
        }
        public async Task<object> Handle(UpdateClassCommand request, CancellationToken cancellationToken)
        {
            var result = await _service.UpdateClass(request.id, request.updateClassDTO);
            return result;
        }
    }
}
