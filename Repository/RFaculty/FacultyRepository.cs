using ProfessorRating.DbContext;
using ProfessorRating.Model;

namespace ProfessorRating.Repository.RFaculty;

public class FacultyRepository(ProfessorRatingDbContext context) : IFacultyRepository
{
    private readonly ProfessorRatingDbContext _context = context;

    public Faculty AddFaculty(Faculty faculty)
    {
        throw new NotImplementedException();
    }

    public Faculty UpdateFaculty(Faculty faculty)
    {
        throw new NotImplementedException();
    }

    public Faculty DeleteFaculty(Faculty faculty)
    {
        throw new NotImplementedException();
    }

    public List<Faculty> GetAllFaculties()
    {
        throw new NotImplementedException();
    }

    public Faculty? GetFacultyById(int id)
    {
        throw new NotImplementedException();
    }
}