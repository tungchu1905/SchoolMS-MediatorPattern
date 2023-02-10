using SchoolMS.Core.Aggregration.ClassAggregration;
using SchoolMS.Core.DTO;
using SchoolMS.Core.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.Core.Services.Interfaces
{
    public interface IClassService
    {
        Task<List<InforClass>> GetAllClass();
        Task<object> GetDetailClass(int id);
        Task<object> CraeteClass(CreateClassDTO createClassDTO);
        Task<object> UpdateClass(int id, UpdateClassDTO updateClassDTO);
        Task<bool> DeleteClass(int id);

        //////// 
        //Task<IPagedList<InforClass>> GetClassPagedList(RequestPaginate requestPaginate);
        Task<object> GetClassPagedList(RequestPaginate requestPaginate);
    }
}
