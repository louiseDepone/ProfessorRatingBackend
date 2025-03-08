using ProfessorRating.Model;

namespace ProfessorRating.Repository.RCourse;

public interface ICourseRepository
{
    Course AddCourse(Course course);
    Course UpdateCourse(Course course);
    void DeleteCourse(Course course);
    List<Course> GetAllCourses();
    Course? GetCourseById(int id);
}

