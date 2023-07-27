using DatabaseWithCSharp.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseWithCSharp;

public class EFTestDbContext : DbContext
{
    public EFTestDbContext(DbContextOptions dbOptions) : base(dbOptions)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Teacher>().ToTable("Teachers");
        
        modelBuilder.Entity<Teacher>()
            .HasOne(d => d.School)
            .WithMany(d => d.Teachers);
        base.OnModelCreating(modelBuilder);
    }
    
    public virtual DbSet<School> Schools { get; set; }
    public virtual DbSet<Teacher> Teachers { get; set; }
    public virtual DbSet<Student> Students { get; set; }
    public virtual DbSet<Subject> Subjects { get; set; }
}