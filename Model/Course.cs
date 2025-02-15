namespace ProfessorRating.Model;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;

    public List<CourseLecturer>? CourseLecturers { get; set; }
}