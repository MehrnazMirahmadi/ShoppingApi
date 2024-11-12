using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Catalogue.BootStrap
{
    public static class BootStrap
    {
        public static void WireUP(IServiceCollection services, string ConnectionString)
        {
            services.AddDbContext<Infrastructure.EF.Persistance.CatalogueContext>(op => { op.UseSqlServer(ConnectionString); }, ServiceLifetime.Scoped);
        }
    }
}
