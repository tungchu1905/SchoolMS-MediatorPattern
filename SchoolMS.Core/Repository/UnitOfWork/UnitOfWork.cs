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
        public IClassInforRepository _classInforRepository { get; }
        //public IStudentRepository _studentRepository { get; }

        public UnitOfWork(AppDbContext context, IClassInforRepository ClassInforRepository
            //, IStudentRepository studentRepository
            )
        {
            _context = context;
            _classInforRepository = ClassInforRepository;
            //_studentRepository = studentRepository;
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
