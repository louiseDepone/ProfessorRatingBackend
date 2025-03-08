using ProfessorRating.Model;

namespace ProfessorRating.Repository.RFaculty;

public interface IFacultyRepository
{
    Faculty AddFaculty(Faculty faculty);
    Faculty UpdateFaculty(Faculty faculty);
    void DeleteFaculty(Faculty faculty);
    List<Faculty> GetAllFaculties();
    Faculty? GetFacultyById(int id);
}