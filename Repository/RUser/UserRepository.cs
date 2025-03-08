using ProfessorRating.DbContext;
using ProfessorRating.Model;

namespace ProfessorRating.Repository.RUser;

public class UserRepository(ProfessorRatingDbContext context) : IUserRepository
{
    private readonly ProfessorRatingDbContext _context = context;

    public User AddUser(User user)
    {
        throw new NotImplementedException();
    }

    public User UpdateUser(User user)
    {
        throw new NotImplementedException();
    }

    public User DeleteUser(User user)
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