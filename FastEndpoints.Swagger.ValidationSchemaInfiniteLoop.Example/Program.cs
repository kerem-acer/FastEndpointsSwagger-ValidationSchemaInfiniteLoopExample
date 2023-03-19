global using FastEndpoints;
using System.Reflection;
using FastEndpoints.Swagger;

var builder = WebApplication.CreateBuilder();
builder.Services.AddFastEndpoints(opt =>
{
    opt.DisableAutoDiscovery = true;
    opt.Assemblies = new[] { Assembly.GetExecutingAssembly() };
});
builder.Services.AddSwaggerDoc();

var app = builder.Build();

app.UseAuthorization();
app.UseFastEndpoints();
app.UseSwaggerGen();
app.Run();