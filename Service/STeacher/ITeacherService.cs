using ProfessorRating.DTO;
using ProfessorRating.Model;

namespace ProfessorRating.Service.STeacher;

public interface ITeacherService
{
    Teacher AddTeacher(CreateTeacherDTO teacher);
    Teacher UpdateTeacher(int id,CreateTeacherDTO teacher);
    void DeleteTeacher(int id);
    List<Teacher> GetAllTeachers();
    Teacher? GetTeacherById(int id);
}