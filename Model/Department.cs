namespace ProfessorRating.Model;

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    
    public List<SchoolDepartment>? SchoolDepartments { get; set; } = new();
}