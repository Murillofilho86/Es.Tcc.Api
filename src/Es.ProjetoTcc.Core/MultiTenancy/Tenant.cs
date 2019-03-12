using Abp.MultiTenancy;
using Es.ProjetoTcc.Authorization.Users;

namespace Es.ProjetoTcc.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
