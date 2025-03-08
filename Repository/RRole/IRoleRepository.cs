using ProfessorRating.Model;
namespace ProfessorRating.Repository.RRole;

public interface IRoleRepository
{
    void AddRole(Role role);
    void UpdateRole(Role role);
    void DeleteRole(Role role);
    List<Role> GetRoles();
    
}