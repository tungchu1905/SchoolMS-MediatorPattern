using AutoMapper;
using SchoolMS.Core.Aggregration.StudentAggregate;
using SchoolMS.Core.DTO;
using SchoolMS.Core.Repository.UnitOfWork;
using SchoolMS.Core.Services.Interfaces;
using SchoolMS.Core.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.Core.Services
{
    public class StudentService : IStudentService
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public StudentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task<object> CraeteStudent(CreateStudentDTO createClassDTO)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<InforStudent>> GetAllStudent()
        {
            throw new NotImplementedException();
        }

        public Task<object> GetDetailStudent(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetStudentPagedList(RequestPaginate requestPaginate)
        {
            List<string> include = new List<string> { "InformationClass" };
            var studentList = await _unitOfWork._studentRepository.GetPagedList(requestPaginate, include);
            if (studentList.Any())
            {
                var result = studentList
               .Select(x => new
               {
                   x.Id,
                   x.StudentName,
                   x.Gender,
                   x.DateOfBirth,
                   x.Address,
                   x.InformationClass.ClassName,
                   x.InformationClass.Grade,
                   x.InformationClass.TeacherName,
                   //Marks = x.InformationMarks.Select(x => new { x.typeOfMark, x.Mark, x.InformationSubject })


               }).ToList();
                if (result != null)
                {
                    return result;
                }
                return null;
            }
            return null;
        }

        public Task<object> UpdateStudent(int id, UpdateStudentDTO updateClassDTO)
        {

            throw new NotImplementedException();
        }
    }
}
