using System.ComponentModel.DataAnnotations.Schema;

namespace ProfessorRating.Model;

public class CourseLecturer
{
    public int Id { get; set; }

    [ForeignKey("Faculty")]
    public int FacultyId { get; set; }
    public Faculty? Faculty { get; set; }

    [ForeignKey("Course")]
    public int CourseId { get; set; }
    public Course? Course { get; set; }

    public List<Rate> Rates { get; set; } = new();
}