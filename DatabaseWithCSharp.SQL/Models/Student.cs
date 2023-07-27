namespace DatabaseWithCSharp.Models;

public class Student
{
    [Key]
    public Guid StudentID { get; set; } = Guid.NewGuid();
    
    [Required]
    public string Name { get; set; }
    
    [Required]
    public DateTime Dob { get; set; }
    
    [Required]
    public string Address { get; set; }
    
    [Required]
    public GradeLevel Grade { get; set; }
}