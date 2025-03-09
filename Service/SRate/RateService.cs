using ProfessorRating.DTO;
using ProfessorRating.Model;
using ProfessorRating.Repository.RRate;
using ProfessorRating.Service.SPinnedRate;

namespace ProfessorRating.Service.SRate;

public class RateService(IRateRepository rateRepository) : IRateService
{
    private IRateRepository  _rateRepository = rateRepository;

    public Rate AddRate(CreateRateDTO rate)
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

    public Rate UpdateRate(int id, CreateRateDTO rate)
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

    public void DeleteRate(int id)
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

    public List<Rate> GetAllRates()
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

    public Rate? GetRateById(int id)
    {
        try
        {
            var rate = _rateRepository.GetRateById(id);
            if (rate is null) return null;
            throw new Exception("Rate not found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}