using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseWithCSharp.Models;

public class Teacher
{
    [Key] 
    public Guid TeacherID { get; set; } = Guid.NewGuid();
    
    [Required]
    public string Title { get; set; }
    
    [MaxLength(100), Required]
    public string FullName { get; set; }
    
    [Required]
    public ICollection<Subject> SubjectsTaught { get; set; }
    
    [Required]
    public GradeLevel Grade { get; set; }

    [ForeignKey("SchoolId")] 
    public Guid SchoolId { get; set; }

    public School School;
}