using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Es.ProjetoTcc.Authorization;

namespace Es.ProjetoTcc
{
    [DependsOn(
        typeof(ProjetoTccCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ProjetoTccApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ProjetoTccAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ProjetoTccApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
