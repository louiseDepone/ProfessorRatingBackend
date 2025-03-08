using ProfessorRating.DbContext;
using ProfessorRating.Model;

namespace ProfessorRating.Repository.RSchoolDepartment;

public class SchoolDepartmentRepository(ProfessorRatingDbContext context): ISchoolDepartmentRepository
{
    private readonly ProfessorRatingDbContext _context = context;

    public SchoolDepartment AddSchoolDepartment(SchoolDepartment schoolDepartment)
    {
        throw new NotImplementedException();
    }

    public SchoolDepartment UpdateSchoolDepartment(SchoolDepartment schoolDepartment)
    {
        throw new NotImplementedException();
    }

    public SchoolDepartment DeleteSchoolDepartment(SchoolDepartment schoolDepartment)
    {
        throw new NotImplementedException();
    }

    public List<SchoolDepartment> GetAllSchoolDepartments()
    {
        throw new NotImplementedException();
    }

    public SchoolDepartment? GetSchoolDepartmentById(int id)
    {
        throw new NotImplementedException();
    }
}