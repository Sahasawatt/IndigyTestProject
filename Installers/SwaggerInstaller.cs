using Microsoft.OpenApi.Models;

namespace indigyTestProject.Installers
{
    public class SwaggerInstaller : IInstallers
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new OpenApiInfo { Title = "indigyTestProject", Version = "v1" });
            });
        }
    }
}
