using ProfessorRating.DbContext;
using ProfessorRating.Model;

namespace ProfessorRating.Repository.RPinnedRate;

public class PinnedRateRepository(ProfessorRatingDbContext context) : IPinnedRateRepository
{
    private readonly ProfessorRatingDbContext _context = context;

    public PinnedRate AddPinnedRate(PinnedRate pinnedRate)
    {
        _context.Add(pinnedRate);
        _context.SaveChanges();
        return pinnedRate;
    }

    public PinnedRate UpdatePinnedRate(PinnedRate pinnedRate)
    {
        _context.Update(pinnedRate);
        _context.SaveChanges();
        return pinnedRate;
    }

    public void DeletePinnedRate(PinnedRate pinnedRate)
    {
        _context.Remove(pinnedRate);
        _context.SaveChanges();
        
    }

    public List<PinnedRate> GetAllPinnedRates()
    {
        return _context.PinnedRate.ToList();
        
    }

    public PinnedRate? GetPinnedRateById(int id)
    {
        return _context.PinnedRate.FirstOrDefault(pr => pr.Id == id);
    }
}