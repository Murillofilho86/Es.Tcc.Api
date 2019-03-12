using System.Threading.Tasks;
using Abp.Application.Services;
using Es.ProjetoTcc.Authorization.Accounts.Dto;

namespace Es.ProjetoTcc.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
