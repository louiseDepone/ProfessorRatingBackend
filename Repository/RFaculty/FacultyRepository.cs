using ProfessorRating.DbContext;
using ProfessorRating.Model;

namespace ProfessorRating.Repository.RFaculty;

public class FacultyRepository(ProfessorRatingDbContext context) : IFacultyRepository
{
    private readonly ProfessorRatingDbContext _context = context;

    public Faculty AddFaculty(Faculty faculty)
    {
        _context.Faculty.Add(faculty);
        _context.SaveChanges();
        return faculty;
    }

    public Faculty UpdateFaculty(Faculty faculty)
    {
        _context.Faculty.Update(faculty);
        _context.SaveChanges();
        return faculty;
    }

    public void DeleteFaculty(Faculty faculty)
    {
        _context.Faculty.Remove(faculty);
        _context.SaveChanges();
    }

    public List<Faculty> GetAllFaculties()
    {
        return _context.Faculty.ToList();
        
    }

    public Faculty? GetFacultyById(int id)
    {
        return _context.Faculty.FirstOrDefault(faculty => faculty.Id == id);
    }
}