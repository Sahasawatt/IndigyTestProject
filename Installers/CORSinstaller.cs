namespace indigyTestProject.Installers
{
    public class CORSinstaller : IInstallers
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin", builder => builder.WithOrigins("").AllowAnyMethod().AllowAnyHeader());
            });

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigin", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });
        }
    }
}
