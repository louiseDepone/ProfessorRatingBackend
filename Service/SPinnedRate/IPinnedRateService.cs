using ProfessorRating.DTO;
using ProfessorRating.Model;

namespace ProfessorRating.Service.SPinnedRate;

public interface IPinnedRateService
{
    PinnedRate AddPinnedRate(CreatePinnedRateDTO pinnedRate);
    PinnedRate UpdatePinnedRate(int id,CreatePinnedRateDTO pinnedRate);
    void DeletePinnedRate(int id);
    List<PinnedRate> GetAllPinnedRates();
    PinnedRate? GetPinnedRateById(int id);
}