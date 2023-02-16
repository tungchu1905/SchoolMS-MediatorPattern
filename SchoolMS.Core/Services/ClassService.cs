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
        public async Task<object> CraeteClass(CreateClassDTO createClassDTO)
        {
            if (createClassDTO == null)
            {
                //_logger.LogError($"Cannot create new Class class name =\"{createClassDTO.ClassName}\".");
                return false;
            }
            var newClass = _mapper.Map<InforClass>(createClassDTO);
            await _unitOfWork._classInforRepository.Add(newClass);
            var result = (_unitOfWork.Complete() > 0) ? true : false;
            if(result)
            {
                return newClass;
            }
            else
                return null;
            //_logger.LogInformation($"Create new Class success for class : \"{createClassDTO.ClassName}\"");
           
        }

        public async Task<bool> DeleteClass(int id)
        {
            if(id > 0)
            {
                var del = await _unitOfWork._classInforRepository.Get(id);
                if (del != null)
                {
                    _unitOfWork._classInforRepository.Delete(del);
                    _unitOfWork.Complete();
                    return true;
                }
                else
                {
                    return false;   
                }
            }
            return false;

        }

        public async Task<List<InforClass>> GetAllClass()
        {
            var classes = await _unitOfWork._classInforRepository.GetAll();
            return (List<InforClass>)classes;
        }

        public async Task<object> GetClassPagedList(RequestPaginate requestPaginate)
        {
            List<string> include = new List<string> { "InformationStudents" };
            var classList = await _unitOfWork._classInforRepository.GetPagedList(requestPaginate, include);
            if (classList.Any())
            {
                var result = classList
               .Select(x => new
               {
                   x.Id,
                   x.ClassName,
                   x.Grade,
                   x.TeacherName,
                   InforStudent = x.InformationStudents.Select(x => new { x.StudentName, x.Gender, x.DateOfBirth, x.Address })
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

        public async Task<object> GetDetailClass(int id)
        {
            List<string> include = new List<string> { "InformationStudents" };
            var classes = await _unitOfWork._classInforRepository.GetAllAsync(include);
            if (classes.Any())
            {
                var result = classes.Where(x => x.Id == id)
               .Select(x => new
               {
                   x.Id,
                   x.ClassName,
                   x.Grade,
                   x.TeacherName,
                   InforStudent = x.InformationStudents.Select(x => new { x.StudentName, x.Gender, x.DateOfBirth, x.Address })
               }).FirstOrDefault();
                if (result != null)
                {
                    //_logger.LogInformation($"Show information of Class : \"{result.ClassName}\"");
                    return result;
                }
                //_logger.LogInformation($"Show information of Class with id : \"{result.Id}\"");
                return null;
            }
            return null;
        }

        public async Task<object> UpdateClass(int id, UpdateClassDTO updateClassDTO)
        {
            if (id > 0)
            {
                var updateClass = await _unitOfWork._classInforRepository.Get(id);
                _mapper.Map(updateClassDTO, updateClass);
                _unitOfWork._classInforRepository.Update(updateClass);
                _unitOfWork.Complete();
                //_logger.LogInformation($"Update ClassName : \"{updateClass.ClassName} \" with id: \"{updateClass.Id}\" successfully ");

                return updateClass;
            }
            //_logger.LogInformation($"Cannot Update Class ");
            return null;
        }
    }
}
