using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Es.ProjetoTcc.MultiTenancy.Dto;

namespace Es.ProjetoTcc.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

