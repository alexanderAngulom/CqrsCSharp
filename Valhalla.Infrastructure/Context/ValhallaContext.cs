

using Microsoft.EntityFrameworkCore;
using Valhalla.Infrastructure.EntityFramework.Entities.Application;
using Valhalla.Infrastructure.EntityFramework.Entities.User;

namespace Valhalla.Infrastructure.Context;

public class ValhallaContext : DbContext
{
    public ValhallaContext(DbContextOptions<ValhallaContext> options) : base(options) { }

    public DbSet<Application> Applications { get; set; }
    public DbSet<ApplicationTenat> ApplicationTenats { get; set; }
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<Rol> Rols{ get; set; }
    public DbSet<Permissions> Permission { get; set; }
    public DbSet<User> User { get; set; }


}
