using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Es.ProjetoTcc.Authorization.Roles;
using Es.ProjetoTcc.Authorization.Users;
using Es.ProjetoTcc.MultiTenancy;
using Es.ProjetoTcc.Models;

namespace Es.ProjetoTcc.EntityFrameworkCore
{
    public class ProjetoTccDbContext : AbpZeroDbContext<Tenant, Role, User, ProjetoTccDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public ProjetoTccDbContext(DbContextOptions<ProjetoTccDbContext> options)
                    : base(options)
        {
        }
    }
}
