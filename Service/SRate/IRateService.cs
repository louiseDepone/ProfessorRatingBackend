using ProfessorRating.DTO;
using ProfessorRating.Model;

namespace ProfessorRating.Service.SRate;

public interface IRateService
{
    Rate AddRate(CreateRateDTO rate);
    Rate UpdateRate(int id,CreateRateDTO rate);
    void DeleteRate(int id);
    List<Rate> GetAllRates();
    Rate? GetRateById(int id);
}