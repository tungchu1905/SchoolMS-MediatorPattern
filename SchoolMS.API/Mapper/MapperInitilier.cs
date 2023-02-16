using AutoMapper;
using SchoolMS.Core.Aggregration.ClassAggregration;
using SchoolMS.Core.Aggregration.StudentAggregate;
using SchoolMS.Core.DTO;

namespace SchoolMS.API.Mapper
{
    public class MapperInitilier : Profile
    {
        public MapperInitilier()
        {
            CreateMap<InforClass, CreateClassDTO>().ReverseMap();
            CreateMap<InforClass, ClassDTO>().ReverseMap();

            CreateMap<InforStudent, CreateStudentDTO>().ReverseMap();
            CreateMap<InforStudent, StudentDTO>().ReverseMap();
        }
    }
}
