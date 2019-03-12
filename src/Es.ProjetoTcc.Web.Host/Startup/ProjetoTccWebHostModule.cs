using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Es.ProjetoTcc.Configuration;

namespace Es.ProjetoTcc.Web.Host.Startup
{
    [DependsOn(
       typeof(ProjetoTccWebCoreModule))]
    public class ProjetoTccWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ProjetoTccWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProjetoTccWebHostModule).GetAssembly());
        }
    }
}
