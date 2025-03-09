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
        try
        {

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public Department UpdateDepartment(int id, CreateDepartmentDTO department)
    {
        throw new NotImplementedException();
        try
        {

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void DeleteDepartment(int id)
    {
        throw new NotImplementedException();
        try
        {

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public List<Department> GetAllDepartments()
    {
        throw new NotImplementedException();
        try
        {

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public Department? GetDepartmentById(int id)
    {
        
        try
        {
            var department = _departmentRepository.GetDepartmentById(id);
            if (department is not null) return department;
            throw new Exception("Department Id not found");

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}