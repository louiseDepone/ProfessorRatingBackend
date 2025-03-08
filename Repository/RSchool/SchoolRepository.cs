using ProfessorRating.DbContext;
using ProfessorRating.Model;

namespace ProfessorRating.Repository.RSchool;

public class SchoolRepository(ProfessorRatingDbContext context): ISchoolRepository
{
    private readonly ProfessorRatingDbContext _context = context;

    public School AddSchool(School school)
    {
        throw new NotImplementedException();
    }

    public School UpdateSchool(School school)
    {
        throw new NotImplementedException();
    }

    public School DeleteSchool(School school)
    {
        throw new NotImplementedException();
    }

    public List<School> GetAllSchools()
    {
        throw new NotImplementedException();
    }

    public School? GetSchoolById(int id)
    {
        throw new NotImplementedException();
    }
}