using Abp.Authorization;
using Es.ProjetoTcc.Authorization.Roles;
using Es.ProjetoTcc.Authorization.Users;

namespace Es.ProjetoTcc.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
