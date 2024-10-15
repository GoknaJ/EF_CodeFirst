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
            new Student { StudentID = 1, StudentName = "Pero", DateOfBirth = new DateTime(1995, 1, 1), Height = 188M, Weight = 85F },
            new Student { StudentID = 2, StudentName = "Ana", DateOfBirth = new DateTime(1997, 5, 15), Height = 170M, Weight = 65F }
        );

        modelBuilder.Entity<Grade>().HasData(
            new Grade { GradeId = 1, GradeName = "5", Section = "Matematika", StudentId = 1 },
            new Grade { GradeId = 2, GradeName = "4", Section = "Hrvatski", StudentId = 1 },
            new Grade { GradeId = 3, GradeName = "5", Section = "Povijest", StudentId = 2 },
            new Grade { GradeId = 4, GradeName = "3", Section = "Geografija", StudentId = 2 },
            new Grade { GradeId = 5, GradeName = "5", Section = "Fizika", StudentId = 1 },
            new Grade { GradeId = 6, GradeName = "4", Section = "Kemija", StudentId = 2 },
            new Grade { GradeId = 7, GradeName = "3", Section = "Biologija", StudentId = 1 }
        );

    }
}
