using ProfessorRating.DbContext;
using ProfessorRating.Model;

namespace ProfessorRating.Repository.RTeacher;

public class TeacherRepository(ProfessorRatingDbContext context): ITeacherRepository
{
    private readonly ProfessorRatingDbContext _context = context;

    public Teacher AddTeacher(Teacher teacher)
    {
         _context.Add(teacher);
         _context.SaveChanges();
         return teacher;
    }

    public Teacher UpdateTeacher(Teacher teacher)
    {
        _context.Update(teacher);
        _context.SaveChanges();
        return teacher;
    }

    public void DeleteTeacher(Teacher teacher)
    {
        _context.Remove(teacher);
        _context.SaveChanges();
        
    }

    public List<Teacher> GetAllTeachers()
    {
        return _context.Teacher.ToList();
        
    }

    public Teacher? GetTeacherById(int id)
    {
        return _context.Teacher.FirstOrDefault(teacher => teacher.Id == id);
    }
}