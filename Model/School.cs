namespace ProfessorRating.Model;

public class School
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public List<SchoolDepartment>? SchoolDepartments { get; set; } = new();
}