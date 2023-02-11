using SchoolMS.Core.Aggregration.StudentAggregate;
using SchoolMS.Core.Data;
using SchoolMS.Core.Repository.General;
using SchoolMS.Core.Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.Core.Repository.Repositories.Implement
{
    public class StudentRepository : GenericRepository<InforStudent>, IStudentRepository
    {
        protected StudentRepository(AppDbContext context) : base(context)
        {
        }
    }
}
