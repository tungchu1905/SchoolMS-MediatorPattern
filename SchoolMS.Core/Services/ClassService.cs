using AutoMapper;
using SchoolMS.Core.Aggregration.ClassAggregration;
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
    public class ClassService : IClassService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public ClassService (IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper= mapper;    
            _unitOfWork= unitOfWork;    
        }
        public Task<bool> CraeteClass(CreateClassDTO createClassDTO)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteClass(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<InforClass>> GetAllClass()
        {
            var classes = await _unitOfWork.classInforRepository.GetAll();
            return (List<InforClass>)classes;
        }

        public async Task<object> GetClassPagedList(RequestPaginate requestPaginate)
        {
            //List<string> include = new List<string> { "InformationStudents" };
            var classList = await _unitOfWork.classInforRepository.GetPagedList(requestPaginate);
            if (classList.Any())
            {
                var result = classList
               .Select(x => new
               {
                   x.Id,
                   x.ClassName,
                   x.Grade,
                   x.TeacherName,
                   //InforStudent = x.InformationStudents.Select(x => new { x.StudentName, x.Gender, x.DateOfBirth, x.Address })
               }).ToList();
                if (result != null)
                {
                    //_logger.LogInformation("Student Class show information ");
                    return result;
                }
                //_logger.LogError("Student Class show nothing ");
                return null;
            }
            //_logger.LogError("Student Class show nothing ");
            return null;
        }

        public Task<object> GetDetailClass(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateClass(int id, UpdateClassDTO updateClassDTO)
        {
            throw new NotImplementedException();
        }
    }
}
