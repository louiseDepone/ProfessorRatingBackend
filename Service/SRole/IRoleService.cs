using ProfessorRating.DTO;
using ProfessorRating.Model;

namespace ProfessorRating.Service.SRole;

public interface IRoleService
{
    void AddRole(CreateRoleDTO role);
    void UpdateRole(int id,CreateRoleDTO role);
    void DeleteRole(int id);
    List<Role> GetRoles();
    Role GetRoleById(int id);
}