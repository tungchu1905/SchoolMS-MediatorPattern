using SchoolMS.Core.Aggregration.StudentAggregate;
using SchoolMS.Core.Data;
using SchoolMS.Core.Repository.General;
using SchoolMS.Core.Repository.Repositories.Interfaces;

namespace SchoolMS.Core.Repository.Repositories.Implement
{
    public class StudentRepository : GenericRepository<InforStudent>, IStudentRepository
    {
        public StudentRepository(AppDbContext context) : base(context)
        {
        }
    }
}
