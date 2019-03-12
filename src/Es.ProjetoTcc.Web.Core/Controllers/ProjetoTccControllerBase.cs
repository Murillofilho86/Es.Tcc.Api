using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Es.ProjetoTcc.Controllers
{
    public abstract class ProjetoTccControllerBase: AbpController
    {
        protected ProjetoTccControllerBase()
        {
            LocalizationSourceName = ProjetoTccConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
