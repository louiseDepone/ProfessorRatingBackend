using ProfessorRating.DbContext;
using ProfessorRating.Model;

namespace ProfessorRating.Repository.RRole;

public class RoleRepository(ProfessorRatingDbContext context): IRoleRepository
{
    private readonly ProfessorRatingDbContext _context = context;

    public void AddRole(Role role)
    {
        _context.Role.Add(role);
        _context.SaveChanges();
    }

    public void UpdateRole(Role role)
    {
        _context.Role.Update(role);
        _context.SaveChanges();
    }

    public void DeleteRole(Role role)
    {
        _context.Role.Remove(role);
        _context.SaveChanges();
    }

    public List<Role> GetRoles()
    {
        return _context.Role.ToList();  
    }

    public Role? GetRoleById(int id)
    {
        return _context.Role.FirstOrDefault(role => role.Id == id);
    }
}