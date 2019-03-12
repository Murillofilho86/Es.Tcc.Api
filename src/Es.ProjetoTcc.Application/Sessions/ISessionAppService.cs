using System.Threading.Tasks;
using Abp.Application.Services;
using Es.ProjetoTcc.Sessions.Dto;

namespace Es.ProjetoTcc.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
