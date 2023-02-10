using SchoolMS.Core.Data;
using SchoolMS.Core.Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.Core.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly AppDbContext _context;
        public IClassInforRepository classInforRepository { get; }

        public UnitOfWork(AppDbContext context, IClassInforRepository ClassInforRepository)
        {
            _context = context;
            classInforRepository = ClassInforRepository;
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
