using System.Threading.Tasks;
using Es.ProjetoTcc.Configuration.Dto;

namespace Es.ProjetoTcc.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
