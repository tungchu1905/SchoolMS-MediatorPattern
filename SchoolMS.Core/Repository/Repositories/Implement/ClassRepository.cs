using SchoolMS.Core.Aggregration.ClassAggregration;
using SchoolMS.Core.Data;
using SchoolMS.Core.Repository.General;
using SchoolMS.Core.Repository.Repositories.Interfaces;

namespace SchoolMS.Core.Repository.Repositories.Implement
{
    public class ClassRepository : GenericRepository<InforClass>, IClassInforRepository
    {
        public ClassRepository(AppDbContext appDbContext) : base(appDbContext) { }
    }
}
