using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Es.ProjetoTcc.EntityFrameworkCore
{
    public static class ProjetoTccDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ProjetoTccDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ProjetoTccDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
