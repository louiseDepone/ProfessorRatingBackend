using ProfessorRating.DbContext;
using ProfessorRating.Model;

namespace ProfessorRating.Repository.RCourse;

public class CourseRepository(ProfessorRatingDbContext context) : ICourseRepository
{
    private readonly ProfessorRatingDbContext _context = context;

    public Course AddCourse(Course course)
    {
        _context.Add(course);
        _context.SaveChanges();
        return course;
    }

    public Course UpdateCourse(Course course)
    {
        _context.Update(course);
        _context.SaveChanges();
        return course;
    }

    public void DeleteCourse(Course course)
    {
        _context.Remove(course);
        _context.SaveChanges();
    }

    public List<Course> GetAllCourses()
    {
        return _context.Course.ToList();
    }

    public Course? GetCourseById(int id)
    {
        return  _context.Course.FirstOrDefault(c => c.Id == id);
    }
}