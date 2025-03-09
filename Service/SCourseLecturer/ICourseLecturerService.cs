using ProfessorRating.DTO;
using ProfessorRating.Model;

namespace ProfessorRating.Service.SCourseLecturer;

public interface ICourseLecturerService
{
    CourseLecturer AddCCourseLecturer(CreateCourseLecturerDTO courseLecturer);
    CourseLecturer UpdateCourseLecturer(int id, CreateCourseLecturerDTO courseLecturer);
    void DeleteCourseLecturer(int id);
    List<CourseLecturer> GetAllCCourseLecturer();
    CourseLecturer? GetCourseLecturerById(int id);
}