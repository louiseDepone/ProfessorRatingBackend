using ProfessorRating.Model;

namespace ProfessorRating.Repository.RSchoolDepartment;

public interface ISchoolDepartmentRepository
{
    SchoolDepartment AddSchoolDepartment(SchoolDepartment schoolDepartment);
    SchoolDepartment UpdateSchoolDepartment(SchoolDepartment schoolDepartment);
    void DeleteSchoolDepartment(SchoolDepartment schoolDepartment);
    List<SchoolDepartment> GetAllSchoolDepartments();
    SchoolDepartment? GetSchoolDepartmentById(int id);
}