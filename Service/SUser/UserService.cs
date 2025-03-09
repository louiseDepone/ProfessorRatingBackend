using ProfessorRating.DTO;
using ProfessorRating.Model;
using ProfessorRating.Repository.RUser;

namespace ProfessorRating.Service.SUser;

public class UserService(IUserRepository userRepository):IUserService
{
    private IUserRepository _userRepository = userRepository;
    public User AddUser(CreateUserDTO user)
    {
        throw new NotImplementedException();
    }

    public User UpdateUser(int id, CreateUserDTO user)
    {
        throw new NotImplementedException();
    }

    public void DeleteUser(int id)
    {
        throw new NotImplementedException();
    }

    public List<User> GetAllUsers()
    {
        throw new NotImplementedException();
    }

    public User? GetUserById(int id)
    {
        throw new NotImplementedException();
    }
}