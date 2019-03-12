using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Es.ProjetoTcc.Configuration.Dto;

namespace Es.ProjetoTcc.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ProjetoTccAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
