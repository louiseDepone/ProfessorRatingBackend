using ProfessorRating.DbContext;
using ProfessorRating.Model;

namespace ProfessorRating.Repository.RDepartment;

public class DepartmentRepository(ProfessorRatingDbContext context) : IDepartmentRepository
{
    private readonly ProfessorRatingDbContext _context = context;

    public Department AddDepartment(Department department)
    {
        _context.Add(department);
        _context.SaveChanges();
        return department;
    }

    public Department UpdateDepartment(Department department)
    {
        _context.Update(department);
        _context.SaveChanges();
        return department;
    }

    public void DeleteDepartment(Department department)
    {
        _context.Remove(department);
        _context.SaveChanges();
        
    }

    public List<Department> GetAllDepartments()
    {
        return _context.Department.ToList();
    }

    public Department? GetDepartmentById(int id)
    {
        return _context.Department.FirstOrDefault(department => department.Id == id);
    }
}