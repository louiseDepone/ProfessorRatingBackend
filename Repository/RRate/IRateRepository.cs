using ProfessorRating.Model;

namespace ProfessorRating.Repository.RRate;

public interface IRateRepository
{
    Rate AddRate(Rate rate);
    Rate UpdateRate(Rate rate);
    Rate DeleteRate(Rate rate);
    List<Rate> GetAllRates();
    Rate? GetRateById(int id);
}