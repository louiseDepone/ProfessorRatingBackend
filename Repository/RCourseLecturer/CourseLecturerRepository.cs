using ProfessorRating.DbContext;
using ProfessorRating.Model;

namespace ProfessorRating.Repository.RCourseLecturer;

public class CourseLecturerRepository(ProfessorRatingDbContext context) : ICourseLecturerRepository
{
    private readonly ProfessorRatingDbContext _context = context;

    public CourseLecturer AddCCourseLecturer(CourseLecturer courseLecturer)
    {
        throw new NotImplementedException();
    }

    public CourseLecturer UpdateCourseLecturer(CourseLecturer courseLecturer)
    {
        throw new NotImplementedException();
    }

    public CourseLecturer DeleteCourseLecturer(CourseLecturer courseLecturer)
    {
        throw new NotImplementedException();
    }

    public List<CourseLecturer> GetAllCCourseLecturer()
    {
        throw new NotImplementedException();
    }

    public CourseLecturer? GetCourseLecturerById(int id)
    {
        throw new NotImplementedException();
    }
}