using ProfessorRating.DbContext;
using ProfessorRating.Model;

namespace ProfessorRating.Repository.RUser;

public class UserRepository(ProfessorRatingDbContext context) : IUserRepository
{
    private readonly ProfessorRatingDbContext _context = context;

    public User AddUser(User user)
    {
         _context.Add(user);
         _context.SaveChanges();
         return user;
    }

    public User UpdateUser(User user)
    {
        _context.Update(user);
        _context.SaveChanges();
        return user;
    }

    public void DeleteUser(User user)
    {
        _context.Remove(user);
        _context.SaveChanges();
    }

    public List<User> GetAllUsers()
    {
        return _context.User.ToList();
        
    }

    public User? GetUserById(int id)
    {
        return _context.User.FirstOrDefault(user => user.Id == id);
    }
}