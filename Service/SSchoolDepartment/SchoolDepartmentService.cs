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
    }

    public SchoolDepartment UpdateSchoolDepartment(int id, CreateSchoolDepartmentDTO schoolDepartment)
    {
        throw new NotImplementedException();
    }

    public void DeleteSchoolDepartment(int id)
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