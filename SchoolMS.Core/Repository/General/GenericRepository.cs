using Microsoft.EntityFrameworkCore;
using X.PagedList;
using SchoolMS.Core.Data;
using SchoolMS.Core.Validation;
namespace SchoolMS.Core.Repository.General
{
    public class GenericRepository<T> : IGenaricRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        protected GenericRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public async Task<T> Get(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }
        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public async Task<IPagedList<T>> GetPagedList(RequestPaginate requestPaginate, List<string> include = null)
        {
            IQueryable<T> query = _context.Set<T>();
            if (include != null)
            {
                foreach (var item in include)
                {
                    query = query.Include(item);
                }
            }
            return await query.AsNoTracking().ToPagedListAsync(requestPaginate.PageNumber, requestPaginate.PageSize);

        }

        public async Task<IList<T>> GetAllAsync(List<string> include = null)
        {
            IQueryable<T> query = _context.Set<T>();
            if (include != null)
            {
                foreach (var incudePropery in include)
                {
                    query = query.Include(incudePropery);
                }
            }
            return await query.AsNoTracking().ToListAsync();
        }
    }

}
