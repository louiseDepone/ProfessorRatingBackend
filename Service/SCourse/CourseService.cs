using ProfessorRating.DTO;
using ProfessorRating.Model;
using ProfessorRating.Repository.RCourse;

namespace ProfessorRating.Service.SCourse;

public class CourseService(ICourseRepository  courseRepository) : ICourseService
{
    private ICourseRepository _courseRepository = courseRepository;
    public Course AddCourse(CreateCourseDTO course)
    {
        throw new NotImplementedException();
    }

    public Course UpdateCourse(int id, CreateCourseDTO course)
    {
        throw new NotImplementedException();
    }

    public void DeleteCourse(int id)
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