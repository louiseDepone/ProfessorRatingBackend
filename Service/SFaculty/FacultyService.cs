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
    }

    public Faculty UpdateFaculty(int id, CreateFacultyDTO faculty)
    {
        throw new NotImplementedException();
    }

    public void DeleteFaculty(int id)
    {
        throw new NotImplementedException();
    }

    public List<Faculty> GetAllFaculties()
    {
        throw new NotImplementedException();
    }

    public Faculty? GetFacultyById(int id)
    {
        throw new NotImplementedException();
    }
}