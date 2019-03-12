using Abp.AutoMapper;
using Es.ProjetoTcc.Authentication.External;

namespace Es.ProjetoTcc.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
