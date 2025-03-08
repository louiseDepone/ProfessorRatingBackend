using ProfessorRating.DbContext;
using ProfessorRating.Model;

namespace ProfessorRating.Repository.RCourse;

public class CourseRepository(ProfessorRatingDbContext context) : ICourseRepository
{
    private readonly ProfessorRatingDbContext _context = context;

    public Course AddCourse(Course course)
    {
        throw new NotImplementedException();
    }

    public Course UpdateCourse(Course course)
    {
        throw new NotImplementedException();
    }

    public Course DeleteCourse(Course course)
    {
        throw new NotImplementedException();
    }

    public List<Course> GetAllCourses()
    {
        throw new NotImplementedException();
    }

    public Course? GetCourseById(int id)
    {
        throw new NotImplementedException();
    }
}