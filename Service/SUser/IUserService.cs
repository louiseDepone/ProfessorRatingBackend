using ProfessorRating.DTO;
using ProfessorRating.Model;

namespace ProfessorRating.Service.SUser;

public interface IUserService
{
    User AddUser(CreateUserDTO user);
    User UpdateUser(int id,CreateUserDTO user);
    void DeleteUser(int id);
    List<User> GetAllUsers();
    User? GetUserById(int id);
}