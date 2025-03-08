using ProfessorRating.Model;

namespace ProfessorRating.Repository.RUser;

public interface IUserRepository
{
    User AddUser(User user);
    User UpdateUser(User user);
    User DeleteUser(User user);
    List<User> GetAllUsers();
    User? GetUserById(int id);
}