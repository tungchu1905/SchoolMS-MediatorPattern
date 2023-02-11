using SchoolMS.Core.Aggregration.ClassAggregration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.Core.Aggregration.StudentAggregate
{
    [Table("InforStudent")]
    public class InforStudent
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "nvarchar")]
        public string StudentName { get; set; }

        [Required]
        public bool Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "nvarchar")]
        public string Address { get; set; }

        public string? FatherName { get; set; }

        public string? MotherName { get; set; }

        [Required]
        [ForeignKey(nameof(InformationClass))]
        public int ClassId { get; set; }
        public virtual InforClass InformationClass { get; set; }

        //public virtual ICollection<InforMark> InformationMarks { get; set; } = default!;
    }
}
