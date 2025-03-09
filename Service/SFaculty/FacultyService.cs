using ProfessorRating.DTO;
using ProfessorRating.Model;
using ProfessorRating.Repository.RFaculty;

namespace ProfessorRating.Service.SFaculty;

public class FacultyService(IFacultyRepository  facultyRepository): IFacultyService
{
    private IFacultyRepository _facultyRepository = facultyRepository;
    public Faculty AddFaculty(CreateFacultyDTO faculty)
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

    public Faculty UpdateFaculty(int id, CreateFacultyDTO faculty)
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

    public void DeleteFaculty(int id)
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

    public List<Faculty> GetAllFaculties()
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

    public Faculty? GetFacultyById(int id)
    {
        try
        {
            var  faculty = _facultyRepository.GetFacultyById(id);
            if (faculty is not null) return faculty;
            throw new Exception("Faculty Id not found");

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}