using ProfessorRating.DbContext;
using ProfessorRating.Model;

namespace ProfessorRating.Repository.RRate;

public class RateRepository(ProfessorRatingDbContext context) : IRateRepository
{
    private readonly ProfessorRatingDbContext _context = context;

    public Rate AddRate(Rate rate)
    {
        throw new NotImplementedException();
    }

    public Rate UpdateRate(Rate rate)
    {
        throw new NotImplementedException();
    }

    public Rate DeleteRate(Rate rate)
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