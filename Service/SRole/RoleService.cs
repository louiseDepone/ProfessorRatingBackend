using ProfessorRating.DTO;
using ProfessorRating.Model;
using ProfessorRating.Repository.RRole;
using ProfessorRating.Service.SPinnedRate;

namespace ProfessorRating.Service.SRole;

public class RoleService(IRoleRepository  rateRepository) : IRoleService
{
    private  IRoleRepository _roleRepository = rateRepository;
    public void AddRole(CreateRoleDTO role)
    {
        throw new NotImplementedException();
    }

    public void UpdateRole(int id, CreateRoleDTO role)
    {
        throw new NotImplementedException();
    }

    public void DeleteRole(int id)
    {
        throw new NotImplementedException();
    }

    public List<Role> GetRoles()
    {
        throw new NotImplementedException();
    }
}