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
    }

    public Rate UpdateRate(int id, CreateRateDTO rate)
    {
        throw new NotImplementedException();
    }

    public void DeleteRate(int id)
    {
        throw new NotImplementedException();
    }

    public List<Rate> GetAllRates()
    {
        throw new NotImplementedException();
    }

    public Rate? GetRateById(int id)
    {
        throw new NotImplementedException();
    }
}