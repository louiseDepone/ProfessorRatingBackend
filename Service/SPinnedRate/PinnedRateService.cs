using ProfessorRating.DTO;
using ProfessorRating.Model;
using ProfessorRating.Repository.RPinnedRate;

namespace ProfessorRating.Service.SPinnedRate;

public class PinnedRateService(IPinnedRateRepository pinnedRateRepository): IPinnedRateService
{
    private IPinnedRateRepository _pinnedRateRepository = pinnedRateRepository;
    public PinnedRate AddPinnedRate(CreatePinnedRateDTO pinnedRate)
    {
        throw new NotImplementedException();
    }

    public PinnedRate UpdatePinnedRate(int id, CreatePinnedRateDTO pinnedRate)
    {
        throw new NotImplementedException();
    }

    public void DeletePinnedRate(int id)
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