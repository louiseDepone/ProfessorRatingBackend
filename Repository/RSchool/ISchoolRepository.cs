using ProfessorRating.Model;

namespace ProfessorRating.Repository.RSchool;

public interface ISchoolRepository
{
    School AddSchool(School school);
    School UpdateSchool(School school);
    void DeleteSchool(School school);
    List<School> GetAllSchools();
    School? GetSchoolById(int id);
}