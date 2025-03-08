using ProfessorRating.DbContext;
using ProfessorRating.Model;

namespace ProfessorRating.Repository.RDepartment;

public class DepartmentRepository(ProfessorRatingDbContext context) : IDepartmentRepository
{
    private readonly ProfessorRatingDbContext _context = context;

    public Department AddDepartment(Department department)
    {
        throw new NotImplementedException();
    }

    public Department UpdateDepartment(Department department)
    {
        throw new NotImplementedException();
    }

    public Department DeleteDepartment(Department department)
    {
        throw new NotImplementedException();
    }

    public List<Department> GetAllDepartments()
    {
        throw new NotImplementedException();
    }

    public Department? GetDepartmentById(int id)
    {
        throw new NotImplementedException();
    }
}