using MediatR;
using SchoolMS.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.Core.Aggregration.ClassAggregration.Commands
{
    public record AddClassCommand(CreateClassDTO CreateClassDTO) : IRequest<object>;

}
