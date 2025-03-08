using ProfessorRating.Model;

namespace ProfessorRating.Repository.RCourseLecturer;

public interface ICourseLecturerRepository
{
    CourseLecturer AddCCourseLecturer(CourseLecturer courseLecturer);
    CourseLecturer UpdateCourseLecturer(CourseLecturer courseLecturer);
    CourseLecturer DeleteCourseLecturer(CourseLecturer courseLecturer);
    List<CourseLecturer> GetAllCCourseLecturer();
    CourseLecturer? GetCourseLecturerById(int id);
}