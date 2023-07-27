namespace DatabaseWithCSharp.Models;

public class School
{
    [Key] // Attribute
    public Guid SchoolId { get; set; } = Guid.NewGuid();
    
    [MaxLength(60)] // Attribute
    public string Name { get; set; }

    [Timestamp]
    public DateTime? CreatedAt { get; internal set; } = DateTime.UtcNow;
}