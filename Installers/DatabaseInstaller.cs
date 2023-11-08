using indigyTestProject.Database;
using Microsoft.EntityFrameworkCore;

namespace indigyTestProject.Installers
{
    public class DatabaseInstaller : IInstallers
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DatabaseContext>(options =>
                          options.UseSqlServer(configuration.GetConnectionString("ConnectionSQLServer")));
        }
    }
}
