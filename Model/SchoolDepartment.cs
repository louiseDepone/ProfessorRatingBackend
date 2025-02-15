using System.ComponentModel.DataAnnotations.Schema;

namespace ProfessorRating.Model;

public class SchoolDepartment
{
    public int Id { get; set; }

    [ForeignKey("School")]
    public int SchoolId { get; set; }
    public School? School { get; set; }
    
    [ForeignKey("Department")]
    public int DepartmentId { get; set; }
    public Department? Department { get; set; }
    
    public List<Faculty>? Faculty { get; set; } = new();
}