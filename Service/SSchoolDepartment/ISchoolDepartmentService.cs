using ProfessorRating.DTO;
using ProfessorRating.Model;

namespace ProfessorRating.Service.SSchoolDepartment;

public interface ISchoolDepartmentService
{
    SchoolDepartment AddSchoolDepartment(CreateSchoolDepartmentDTO schoolDepartment);
    SchoolDepartment UpdateSchoolDepartment(int id, CreateSchoolDepartmentDTO schoolDepartment);
    void DeleteSchoolDepartment(int id);
    List<SchoolDepartment> GetAllSchoolDepartments();
    SchoolDepartment? GetSchoolDepartmentById(int id);
}