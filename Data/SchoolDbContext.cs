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
        modelBuilder.Entity<Student>().HasKey(s => s.StudentID);
        modelBuilder.Entity<Grade>().HasKey(g => g.GradeId);
        modelBuilder.Entity<Grade>().HasOne(g => g.Student).WithMany(s => s.Grades).HasForeignKey(g => g.StudentId);
    }

    public void Seed()
    {
        Students.Add(new Student { StudentName = "Pero", DateOfBirth = new DateTime(1995, 1, 1), Height = 1.80m, Weight = 70.0f });
        Students.Add(new Student { StudentName = "Ana", DateOfBirth = new DateTime(1997, 2, 2), Height = 1.60m, Weight = 55.0f });

        Grades.Add(new Grade { GradeName = "A", Section = "Matematika", StudentId = 1 });
        Grades.Add(new Grade { GradeName = "B", Section = "Kemija", StudentId = 1 });
        Grades.Add(new Grade { GradeName = "A", Section = "Hrvatski", StudentId = 2 });
        Grades.Add(new Grade { GradeName = "B", Section = "Povijest", StudentId = 2 });
        Grades.Add(new Grade { GradeName = "C", Section = "Fizika", StudentId = 1 });
        Grades.Add(new Grade { GradeName = "A", Section = "Biologija", StudentId = 2 });
        Grades.Add(new Grade { GradeName = "B", Section = "Engleski", StudentId = 1 });
    }
}
