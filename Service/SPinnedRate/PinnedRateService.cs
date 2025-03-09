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
        try
        {

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public PinnedRate UpdatePinnedRate(int id, CreatePinnedRateDTO pinnedRate)
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

    public void DeletePinnedRate(int id)
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

    public List<PinnedRate> GetAllPinnedRates()
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

    public PinnedRate? GetPinnedRateById(int id)
    {
        try
        {
            var pinnedRate = _pinnedRateRepository.GetPinnedRateById(id);
            if (pinnedRate is null) return null;
            throw new Exception("Pinned Rate not found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}