using SchoolMS.Core.Aggregration.StudentAggregate;
using SchoolMS.Core.DTO;
using SchoolMS.Core.Services.Interfaces;
using SchoolMS.Core.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.Core.Services
{
    public class StudentService : IStudentService
    {
        public Task<object> CraeteStudent(CreateStudentDTO createClassDTO)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<InforStudent>> GetAllStudent()
        {
            throw new NotImplementedException();
        }

        public Task<object> GetDetailStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetStudentPagedList(RequestPaginate requestPaginate)
        {
            throw new NotImplementedException();
        }

        public Task<object> UpdateStudent(int id, UpdateStudentDTO updateClassDTO)
        {
            throw new NotImplementedException();
        }
    }
}
