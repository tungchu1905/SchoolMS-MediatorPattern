using X.PagedList;
using SchoolMS.Core.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.Core.Repository.General
{
    public  interface IGenaricRepository<T> where T : class
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<IPagedList<T>> GetPagedList(RequestPaginate requestPaginate, List<string> include = null);


        Task<IList<T>> GetAllAsync(List<string> include = null);
    }
}
