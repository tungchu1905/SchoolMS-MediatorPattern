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

        public Task<object> GetClassPagedList(RequestPaginate requestPaginate)
        {
            throw new NotImplementedException();
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
