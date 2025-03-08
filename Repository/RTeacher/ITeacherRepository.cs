using ProfessorRating.Model;

namespace ProfessorRating.Repository.RTeacher;

public interface ITeacherRepository
{
    Teacher AddTeacher(Teacher teacher);
    Teacher UpdateTeacher(Teacher teacher);
    void DeleteTeacher(Teacher teacher);
    List<Teacher> GetAllTeachers();
    Teacher? GetTeacherById(int id);
}