using ProfessorRating.DTO;
using ProfessorRating.Model;
using ProfessorRating.Repository.RSchoolDepartment;

namespace ProfessorRating.Service.SSchoolDepartment;

public class SchoolDepartmentService(ISchoolDepartmentRepository  schoolDepartmentRepository): ISchoolDepartmentService
{
    private ISchoolDepartmentRepository _schoolDepartmentRepository = schoolDepartmentRepository;
    public SchoolDepartment AddSchoolDepartment(CreateSchoolDepartmentDTO schoolDepartment)
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

    public SchoolDepartment UpdateSchoolDepartment(int id, CreateSchoolDepartmentDTO schoolDepartment)
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

    public void DeleteSchoolDepartment(int id)
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

    public List<SchoolDepartment> GetAllSchoolDepartments()
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

    public SchoolDepartment? GetSchoolDepartmentById(int id)
    {
        try
        {
            var schooldepartment = _schoolDepartmentRepository.GetSchoolDepartmentById(id);
            if (schooldepartment is not null) return schooldepartment;
            throw new Exception("School department not found");          
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}