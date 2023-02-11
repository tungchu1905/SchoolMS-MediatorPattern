using SchoolMS.Core.Aggregration.StudentAggregate;
using SchoolMS.Core.DTO;
using SchoolMS.Core.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.Core.Services.Interfaces
{
    public interface IStudentService
    {
        Task<List<InforStudent>> GetAllStudent();
        Task<object> GetDetailStudent(int id);
        Task<object> CraeteStudent(CreateStudentDTO createClassDTO);
        Task<object> UpdateStudent(int id, UpdateStudentDTO updateClassDTO);
        Task<bool> DeleteStudent(int id);

        //////// 
        Task<object> GetStudentPagedList(RequestPaginate requestPaginate);
    }
}
