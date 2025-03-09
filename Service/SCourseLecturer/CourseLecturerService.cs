using ProfessorRating.DTO;
using ProfessorRating.Model;
using ProfessorRating.Repository.RCourseLecturer;

namespace ProfessorRating.Service.SCourseLecturer;

public class CourseLecturerService(ICourseLecturerRepository  courseLecturerRepository): ICourseLecturerService
{
    private ICourseLecturerRepository _courseLecturerRepository = courseLecturerRepository;
    public CourseLecturer AddCCourseLecturer(CreateCourseLecturerDTO courseLecturer)
    {
        throw new NotImplementedException();
    }

    public CourseLecturer UpdateCourseLecturer(int id, CreateCourseLecturerDTO courseLecturer)
    {
        throw new NotImplementedException();
    }

    public void DeleteCourseLecturer(int id)
    {
        throw new NotImplementedException();
    }

    public List<CourseLecturer> GetAllCCourseLecturer()
    {
        throw new NotImplementedException();
    }

    public CourseLecturer? GetCourseLecturerById(int id)
    {
        throw new NotImplementedException();
    }
}