using ProfessorRating.DbContext;
using ProfessorRating.Model;

namespace ProfessorRating.Repository.RRate;

public class RateRepository(ProfessorRatingDbContext context) : IRateRepository
{
    private readonly ProfessorRatingDbContext _context = context;

    public Rate AddRate(Rate rate)
    {
        _context.Rate.Add(rate);
        _context.SaveChanges();
        return rate;
    }

    public Rate UpdateRate(Rate rate)
    {
        _context.Rate.Update(rate);
        _context.SaveChanges();
        return rate;
    }

    public void DeleteRate(Rate rate)
    {
        _context.Rate.Remove(rate);
         _context.SaveChanges();
    }

    public List<Rate> GetAllRates()
    {
        return _context.Rate.ToList();
    }

    public Rate? GetRateById(int id)
    {
        return _context.Rate.FirstOrDefault(rate => rate.Id == id);
    }
}