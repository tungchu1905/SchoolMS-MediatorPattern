using SchoolMS.Core.Aggregration.StudentAggregate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.Core.Aggregration.ClassAggregration
{
    [Table("InforClass")]
    public class InforClass
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [Column(TypeName = "nvarchar")]
        public string ClassName { get; set; }
        [Required]
        public int Grade { get; set; }
        [Required]
        [StringLength(100)]
        [Column(TypeName = "nvarchar")]
        public string TeacherName { get; set; }
        public virtual ICollection<InforStudent> InformationStudents { get; set; } = default!;
    }
}
