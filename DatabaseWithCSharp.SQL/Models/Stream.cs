namespace DatabaseWithCSharp.Models;

public class Stream
{
    [Key] 
    public Guid StreamID { get; set; } = Guid.NewGuid();
    
    [Required]
    public string StreamName { get; set; }
    
    [Required]
    public GradeLevel Grade { get; set; }
}