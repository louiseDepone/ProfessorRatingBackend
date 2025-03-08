using ProfessorRating.Model;

namespace ProfessorRating.Repository.RPinnedRate;

public interface IPinnedRateRepository
{
    PinnedRate AddPinnedRate(PinnedRate pinnedRate);
    PinnedRate UpdatePinnedRate(PinnedRate pinnedRate);
    PinnedRate DeletePinnedRate(PinnedRate pinnedRate);
    List<PinnedRate> GetAllPinnedRates();
    PinnedRate? GetPinnedRateById(int id);
}