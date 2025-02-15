using System.ComponentModel.DataAnnotations.Schema;

namespace ProfessorRating.Model;

public class Faculty
{
    public int Id { get; set; }

    [ForeignKey("Teacher")]
    public int TeacherId { get; set; }
    public Teacher? Teacher { get; set; }
    
    [ForeignKey("SchoolDepartment")]
    public int SchoolDepartmentId { get; set; }
    public SchoolDepartment? SchoolDepartment { get; set; }

    public List<CourseLecturer>? CourseLecturers { get; set; }
}