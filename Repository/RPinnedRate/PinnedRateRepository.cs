using ProfessorRating.DbContext;
using ProfessorRating.Model;

namespace ProfessorRating.Repository.RPinnedRate;

public class PinnedRateRepository(ProfessorRatingDbContext context) : IPinnedRateRepository
{
    private readonly ProfessorRatingDbContext _context = context;

    public PinnedRate AddPinnedRate(PinnedRate pinnedRate)
    {
        throw new NotImplementedException();
    }

    public PinnedRate UpdatePinnedRate(PinnedRate pinnedRate)
    {
        throw new NotImplementedException();
    }

    public PinnedRate DeletePinnedRate(PinnedRate pinnedRate)
    {
        throw new NotImplementedException();
    }

    public List<PinnedRate> GetAllPinnedRates()
    {
        throw new NotImplementedException();
    }

    public PinnedRate? GetPinnedRateById(int id)
    {
        throw new NotImplementedException();
    }
}