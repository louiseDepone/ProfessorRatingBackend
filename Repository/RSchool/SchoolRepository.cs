using ProfessorRating.DbContext;
using ProfessorRating.Model;

namespace ProfessorRating.Repository.RSchool;

public class SchoolRepository(ProfessorRatingDbContext context): ISchoolRepository
{
    private readonly ProfessorRatingDbContext _context = context;

    public School AddSchool(School school)
    {
        _context.School.Add(school);
        _context.SaveChanges();
        return school;
    }

    public School UpdateSchool(School school)
    {
        _context.School.Update(school);
        _context.SaveChanges();
        return school;
    }

    public void DeleteSchool(School school)
    {
        _context.School.Remove(school);
        _context.SaveChanges();
        
    }

    public List<School> GetAllSchools()
    {
        return _context.School.ToList();
        
    }

    public School? GetSchoolById(int id)
    {
        return _context.School.FirstOrDefault(school => school.Id == id);
    }
}