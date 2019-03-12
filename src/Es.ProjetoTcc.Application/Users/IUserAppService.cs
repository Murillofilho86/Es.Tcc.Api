using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Es.ProjetoTcc.Roles.Dto;
using Es.ProjetoTcc.Users.Dto;

namespace Es.ProjetoTcc.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
