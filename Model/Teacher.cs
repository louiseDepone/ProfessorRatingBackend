namespace ProfessorRating.Model;

public class Teacher
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public List<Faculty>? Faculty { get; set; } = new();
}