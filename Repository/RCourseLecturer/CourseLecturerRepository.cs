using ProfessorRating.DbContext;
using ProfessorRating.Model;

namespace ProfessorRating.Repository.RCourseLecturer;

public class CourseLecturerRepository(ProfessorRatingDbContext context) : ICourseLecturerRepository
{
    private readonly ProfessorRatingDbContext _context = context;

    public CourseLecturer AddCCourseLecturer(CourseLecturer courseLecturer)
    {
        _context.CourseLecturer.Add(courseLecturer);
        _context.SaveChanges();
        return courseLecturer;
    }

    public CourseLecturer UpdateCourseLecturer(CourseLecturer courseLecturer)
    {
        _context.CourseLecturer.Update(courseLecturer);
        _context.SaveChanges();
        return courseLecturer;
    }

    public void DeleteCourseLecturer(CourseLecturer courseLecturer)
    {
        _context.CourseLecturer.Remove(courseLecturer);
        _context.SaveChanges();
    }

    public List<CourseLecturer> GetAllCCourseLecturer()
    {
        return _context.CourseLecturer.ToList();
    }

    public CourseLecturer? GetCourseLecturerById(int id)
    {
        return _context.CourseLecturer.FirstOrDefault(c => c.Id == id);
    }
}