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
        try
        {

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public Course UpdateCourse(int id, CreateCourseDTO course)
    {
        throw new NotImplementedException();
        try
        {

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }    }

    public void DeleteCourse(int id)
    {
        throw new NotImplementedException();
        try
        {

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }    }

    public List<Course> GetAllCourses()
    {
        throw new NotImplementedException();
        try
        {

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }    }

    public Course? GetCourseById(int id)
    {
        throw new NotImplementedException();
        try
        {

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }    }
}