using ProfessorRating.DbContext;
using ProfessorRating.Model;

namespace ProfessorRating.Repository.RTeacher;

public class TeacherRepository(ProfessorRatingDbContext context): ITeacherRepository
{
    private readonly ProfessorRatingDbContext _context = context;

    public Teacher AddTeacher(Teacher teacher)
    {
        throw new NotImplementedException();
    }

    public Teacher UpdateTeacher(Teacher teacher)
    {
        throw new NotImplementedException();
    }

    public Teacher DeleteTeacher(Teacher teacher)
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