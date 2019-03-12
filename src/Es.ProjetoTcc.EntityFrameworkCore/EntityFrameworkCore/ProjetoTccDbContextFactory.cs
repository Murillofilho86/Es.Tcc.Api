using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Es.ProjetoTcc.Configuration;
using Es.ProjetoTcc.Web;

namespace Es.ProjetoTcc.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ProjetoTccDbContextFactory : IDesignTimeDbContextFactory<ProjetoTccDbContext>
    {
        public ProjetoTccDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ProjetoTccDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ProjetoTccDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ProjetoTccConsts.ConnectionStringName));

            return new ProjetoTccDbContext(builder.Options);
        }
    }
}
