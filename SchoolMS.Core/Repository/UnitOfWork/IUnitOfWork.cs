using SchoolMS.Core.Aggregration.ClassAggregration;
using SchoolMS.Core.Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.Core.Repository.UnitOfWork
{
    public  interface IUnitOfWork : IDisposable
    {
        IClassInforRepository _classInforRepository { get; }
        //IStudentRepository _studentRepository { get; }

        int Complete();
    }
}
