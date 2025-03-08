using ProfessorRating.DbContext;
using ProfessorRating.Model;

namespace ProfessorRating.Repository.RSchoolDepartment;

public class SchoolDepartmentRepository(ProfessorRatingDbContext context): ISchoolDepartmentRepository
{
    private readonly ProfessorRatingDbContext _context = context;

    public SchoolDepartment AddSchoolDepartment(SchoolDepartment schoolDepartment)
    {
        _context.SchoolDepartment.Add(schoolDepartment);
        _context.SaveChanges();
        return schoolDepartment;
    }

    public SchoolDepartment UpdateSchoolDepartment(SchoolDepartment schoolDepartment)
    {
        _context.SchoolDepartment.Update(schoolDepartment);
        _context.SaveChanges();
        return schoolDepartment;
    }

    public void DeleteSchoolDepartment(SchoolDepartment schoolDepartment)
    {
        _context.SchoolDepartment.Remove(schoolDepartment);
        _context.SaveChanges();
        
    }

    public List<SchoolDepartment> GetAllSchoolDepartments()
    {
        return _context.SchoolDepartment.ToList();
        
    }

    public SchoolDepartment? GetSchoolDepartmentById(int id)
    {
        return _context.SchoolDepartment.FirstOrDefault(schoolDepartment => schoolDepartment.Id == id);
    }
}