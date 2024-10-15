using EF_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_CodeFirst.Data;

public class SchoolDbContext : DbContext
{
    public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options) { }

    public DbSet<Student> Students { get; set; }
    public DbSet<Grade> Grades { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().HasData(
            new Student { StudentID = 1, StudentName = "Pero", DateOfBirth = new DateTime(1995, 1, 1), Height = 188, Weight = 85 },
            new Student { StudentID = 2, StudentName = "Ana", DateOfBirth = new DateTime(1997, 5, 15), Height = 170, Weight = 65 }
        );

        modelBuilder.Entity<Grade>().HasData(
            new Grade { GradeId = 001, GradeName = "A", Section = "1", StudentId = 1 },
            new Grade { GradeId = 002, GradeName = "B", Section = "1", StudentId = 1 },
            new Grade { GradeId = 003, GradeName = "C", Section = "2", StudentId = 2 },
            new Grade { GradeId = 004, GradeName = "D", Section = "2", StudentId = 2 },
            new Grade { GradeId = 005, GradeName = "E", Section = "1", StudentId = 1 },
            new Grade { GradeId = 006, GradeName = "F", Section = "2", StudentId = 2 },
            new Grade { GradeId = 007, GradeName = "G", Section = "1", StudentId = 1 }
        );

    }
}
