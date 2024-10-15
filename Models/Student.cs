﻿namespace EF_CodeFirst.Models;

public class Student
{
    public int StudentID { get; set; }
    public required string StudentName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public decimal Height { get; set; }
    public float Weight { get; set; }
    public ICollection<Grade>? Grades { get; set; }
}
