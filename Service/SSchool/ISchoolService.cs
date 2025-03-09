using ProfessorRating.DTO;
using ProfessorRating.Model;

namespace ProfessorRating.Service.SSchool;

public interface ISchoolService
{
    School AddSchool(CreateSchoolDTO school);
    School UpdateSchool(int id,CreateSchoolDTO school);
    void DeleteSchool(int id);
    List<School> GetAllSchools();
    School? GetSchoolById(int id);
}