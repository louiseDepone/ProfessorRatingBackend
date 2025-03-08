using ProfessorRating.Model;

namespace ProfessorRating.Repository.RDepartment;

public interface IDepartmentRepository
{
    Department AddDepartment(Department department);
    Department UpdateDepartment(Department department);
    Department DeleteDepartment(Department department);
    List<Department> GetAllDepartments();
    Department? GetDepartmentById(int id);
}