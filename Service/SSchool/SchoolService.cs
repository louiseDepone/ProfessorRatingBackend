using ProfessorRating.DTO;
using ProfessorRating.Model;
using ProfessorRating.Repository.RSchool;
using ProfessorRating.Service.SPinnedRate;

namespace ProfessorRating.Service.SSchool;

public class SchoolService(ISchoolRepository  schoolRepository) : ISchoolService
{   
    private  ISchoolRepository _schoolRepository = schoolRepository;
    public School AddSchool(CreateSchoolDTO school)
    {
        throw new NotImplementedException();
    }

    public School UpdateSchool(int id, CreateSchoolDTO school)
    {
        throw new NotImplementedException();
    }

    public void DeleteSchool(int id)
    {
        throw new NotImplementedException();
    }

    public List<School> GetAllSchools()
    {
        throw new NotImplementedException();
    }

    public School? GetSchoolById(int id)
    {
        throw new NotImplementedException();
    }
}