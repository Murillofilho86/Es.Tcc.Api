using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Es.ProjetoTcc.Configuration;
using Es.ProjetoTcc.EntityFrameworkCore;
using Es.ProjetoTcc.Migrator.DependencyInjection;

namespace Es.ProjetoTcc.Migrator
{
    [DependsOn(typeof(ProjetoTccEntityFrameworkModule))]
    public class ProjetoTccMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ProjetoTccMigratorModule(ProjetoTccEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(ProjetoTccMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                ProjetoTccConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProjetoTccMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
