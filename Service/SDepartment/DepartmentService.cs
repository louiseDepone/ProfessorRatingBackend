using ProfessorRating.DTO;
using ProfessorRating.Model;
using ProfessorRating.Repository.RDepartment;

namespace ProfessorRating.Service.SDepartment;

public class DepartmentService(IDepartmentRepository  departmentRepository): IDepartmentService
{
    private  IDepartmentRepository _departmentRepository = departmentRepository;                 
    public Department AddDepartment(CreateDepartmentDTO department)
    {
        throw new NotImplementedException();
    }

    public Department UpdateDepartment(int id, CreateDepartmentDTO department)
    {
        throw new NotImplementedException();
    }

    public void DeleteDepartment(int id)
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