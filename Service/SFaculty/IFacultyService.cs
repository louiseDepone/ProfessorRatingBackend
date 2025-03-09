using ProfessorRating.DTO;
using ProfessorRating.Model;

namespace ProfessorRating.Service.SFaculty;

public interface IFacultyService
{
    Faculty AddFaculty(CreateFacultyDTO faculty);
    Faculty UpdateFaculty(int id,CreateFacultyDTO faculty);
    void DeleteFaculty(int id);
    List<Faculty> GetAllFaculties();
    Faculty? GetFacultyById(int id);
}