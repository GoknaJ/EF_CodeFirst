namespace EF_CodeFirst.Models;

public class Grade
{
    public int GradeId { get; set; }
    public required string GradeName { get; set; }
    public required string Section { get; set; }
    public int StudentId { get; set; }
    public Student? Student { get; set; }
}
