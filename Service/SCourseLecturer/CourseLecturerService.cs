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
        try
        {

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public CourseLecturer UpdateCourseLecturer(int id, CreateCourseLecturerDTO courseLecturer)
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

    public void DeleteCourseLecturer(int id)
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

    public List<CourseLecturer> GetAllCCourseLecturer()
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

    public CourseLecturer? GetCourseLecturerById(int id)
    {
        try
        {
            var lecturer = _courseLecturerRepository.GetCourseLecturerById(id);
            if (lecturer is not null) return lecturer;
            throw new Exception("Course Lecturer Id not found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}