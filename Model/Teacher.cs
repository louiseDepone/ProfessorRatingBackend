namespace ProfessorRating.Model;

public class Teacher
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public List<Faculty>? Faculty { get; set; } = new();
}