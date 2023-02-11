using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolMS.Core.Aggregration.StudentAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.Core.Data.DataConfiguration
{
    public class StudentConfig : IEntityTypeConfiguration<InforStudent>
    {
        public void Configure(EntityTypeBuilder<InforStudent> builder)
        {
            // seed data
            builder.HasData(
                  new InforStudent() { Id = 1, StudentName = "Nguyen Khanh Toan", Gender = true, DateOfBirth = new DateTime(2015, 12, 31), Address = "Ha Noi", FatherName = "", MotherName = "", ClassId = 1 },
              new InforStudent() { Id = 2, StudentName = "Nguyen Ngoc Long", Gender = false, DateOfBirth = new DateTime(2015, 12, 31), Address = "Ha Noi", FatherName = "", MotherName = "", ClassId = 1 },
              new InforStudent() { Id = 3, StudentName = "Chu Khanh Toan", Gender = true, DateOfBirth = new DateTime(2015, 12, 31), Address = "Ha Noi", FatherName = "", MotherName = "", ClassId = 2 },
              new InforStudent() { Id = 4, StudentName = "Hoang Van Long", Gender = true, DateOfBirth = new DateTime(2015, 12, 31), Address = "Ha Noi", FatherName = "", MotherName = "", ClassId = 2 },
              new InforStudent() { Id = 5, StudentName = "Pham Thanh Xuan", Gender = false, DateOfBirth = new DateTime(2014, 12, 31), Address = "Ha Noi", FatherName = "", MotherName = "", ClassId = 3 },
              new InforStudent() { Id = 6, StudentName = "Vu Duc Khanh", Gender = true, DateOfBirth = new DateTime(2014, 12, 31), Address = "Ha Noi", FatherName = "", MotherName = "", ClassId = 3 },
              new InforStudent() { Id = 7, StudentName = "Chuong Thi Khanh Toan", Gender = false, DateOfBirth = new DateTime(2014, 12, 31), Address = "Ha Noi", FatherName = "", MotherName = "", ClassId = 4 },
              new InforStudent() { Id = 8, StudentName = "Nguyen Thanh Long", Gender = true, DateOfBirth = new DateTime(2014, 12, 31), Address = "Ha Noi", FatherName = "", MotherName = "", ClassId = 4 },
              new InforStudent() { Id = 9, StudentName = "Do Thi Huong", Gender = false, DateOfBirth = new DateTime(2013, 12, 31), Address = "Ha Noi", FatherName = "", MotherName = "", ClassId = 5 },
              new InforStudent() { Id = 10, StudentName = "Truong Dang Hieu", Gender = true, DateOfBirth = new DateTime(2013, 12, 31), Address = "Ha Noi", FatherName = "", MotherName = "", ClassId = 5 },
              new InforStudent() { Id = 11, StudentName = "Truong Quoc Sinh", Gender = true, DateOfBirth = new DateTime(2013, 12, 31), Address = "Ha Noi", FatherName = "", MotherName = "", ClassId = 6 },
              new InforStudent() { Id = 12, StudentName = "Nguyen Thu Huong", Gender = false, DateOfBirth = new DateTime(2013, 12, 31), Address = "Ha Noi", FatherName = "", MotherName = "", ClassId = 6 },
              new InforStudent() { Id = 13, StudentName = "Do Thi Mai", Gender = false, DateOfBirth = new DateTime(2013, 12, 31), Address = "Ha Noi", FatherName = "", MotherName = "", ClassId = 6 },
              new InforStudent() { Id = 14, StudentName = "Nguyen Khanh Mai", Gender = true, DateOfBirth = new DateTime(2015, 12, 31), Address = "Ha Noi", FatherName = "", MotherName = "", ClassId = 1 });

        }
    }
}
