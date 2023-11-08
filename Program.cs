using Autofac;
using Autofac.Extensions.DependencyInjection;
using indigyTestProject.Installers;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.InstallServiceInAssembly(builder.Configuration);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterAssemblyTypes(Assembly.GetEntryAssembly())
    .Where(t => t.Name.EndsWith("Service"))
    .AsImplementedInterfaces();
});

var app = builder.Build();




if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TestIndigy"));
}


app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseCors("AllowAllOrigin");
app.UseAuthorization();
app.MapControllers();

app.Run();
