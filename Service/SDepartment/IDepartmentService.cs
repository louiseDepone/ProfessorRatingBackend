using ProfessorRating.DTO;
using ProfessorRating.Model;

namespace ProfessorRating.Service.SDepartment;

public interface IDepartmentService
{
    Department AddDepartment(CreateDepartmentDTO department);
    Department UpdateDepartment(int id, CreateDepartmentDTO department);
    void DeleteDepartment(int id);
    List<Department> GetAllDepartments();
    Department? GetDepartmentById(int id);
}