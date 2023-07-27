namespace DatabaseWithCSharp.Models;

public class Subject
{
    [Key]
    public Guid SubjectId { get; set; }
    
    [Required]
    public string SubjectName { get; set; }
}