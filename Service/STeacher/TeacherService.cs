using ProfessorRating.DTO;
using ProfessorRating.Model;
using ProfessorRating.Repository.RTeacher;

namespace ProfessorRating.Service.STeacher;

public class TeacherService(ITeacherRepository  teacherRepository) : ITeacherService
{
    private ITeacherRepository _teacherRepository = teacherRepository;
    public Teacher AddTeacher(CreateTeacherDTO teacher)
    {
        throw new NotImplementedException();
    }

    public Teacher UpdateTeacher(int id, CreateTeacherDTO teacher)
    {
        throw new NotImplementedException();
    }

    public void DeleteTeacher(int id)
    {
        throw new NotImplementedException();
    }

    public List<Teacher> GetAllTeachers()
    {
        throw new NotImplementedException();
    }

    public Teacher? GetTeacherById(int id)
    {
        throw new NotImplementedException();
    }
}