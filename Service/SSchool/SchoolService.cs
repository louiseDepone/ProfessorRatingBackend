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
        try
        {

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public School UpdateSchool(int id, CreateSchoolDTO school)
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

    public void DeleteSchool(int id)
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

    public List<School> GetAllSchools()
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

    public School? GetSchoolById(int id)
    {
        try
        {
            var school = _schoolRepository.GetSchoolById(id);
            if (school is not null) return school;
            throw new Exception("School not found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}