using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolMS.Core.Aggregration.ClassAggregration;
using SchoolMS.Core.Aggregration.StudentAggregate;
using SchoolMS.Core.Data.DataConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.Core.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<InforClass> inforClasses { get; set; }
        public DbSet<InforStudent> inforStudents { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ClassConfig());
            builder.ApplyConfiguration(new StudentConfig());

        }
    }
   
}
