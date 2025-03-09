using ProfessorRating.DTO;
using ProfessorRating.Model;

namespace ProfessorRating.Service.SCourse;

public interface ICourseService
{
    Course AddCourse(CreateCourseDTO course);
    Course UpdateCourse(int id,CreateCourseDTO course);
    void DeleteCourse(int id);
    List<Course> GetAllCourses();
    Course? GetCourseById(int id);
}