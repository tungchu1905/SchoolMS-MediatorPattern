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
    public class DeleteClassHandler : IRequestHandler<DeleteClassCommand, bool>
    {
        private IClassService _service;
        public DeleteClassHandler(IClassService service)
        {
            this._service = service;
        }
        public async Task<bool> Handle(DeleteClassCommand request, CancellationToken cancellationToken)
        {
            return await _service.DeleteClass(request.id);
        }
    }
}
