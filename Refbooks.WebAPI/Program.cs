using Microsoft.OpenApi.Models;
using Refbooks.Application;
using Refbooks.Persistence;
using Refbooks.WebAPI.Middleware;
using System.Reflection;
using System.Text;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var services = builder.Services;
var configuration = builder.Configuration;

services.AddResponseCaching();
services.AddControllers(options =>
{
    options.CacheProfiles.Add("All300",
        new CacheProfile()
        {
            Duration = 300,
            Location = ResponseCacheLocation.Any
        });
    options.CacheProfiles.Add("ByCode300",
        new CacheProfile()
        {
            Duration = 300,
            Location = ResponseCacheLocation.Any,
            VaryByQueryKeys = new[]{"code"}
        });
    options.CacheProfiles.Add("AllRelevant300",
        new CacheProfile()
        {
            Duration = 300,
            Location = ResponseCacheLocation.Any,
            VaryByQueryKeys = new[]{"date"}
        });
    options.CacheProfiles.Add("RelevantByCode300",
        new CacheProfile()
        {
            Duration = 300,
            Location = ResponseCacheLocation.Any,
            VaryByQueryKeys = new string[]{"code","date"}
        });
});

services.AddEndpointsApiExplorer();
services.AddSwaggerGen(config =>
{
    config.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = $"Refbooks API",
        Contact = new OpenApiContact
        {
            Name = "Nn1X",
            Email = "aryrate@gmail.com"
        }
    });

    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    config.IncludeXmlComments(xmlPath);

});

services.AddTransient<FactoryCustomExceptionHandlerMiddleware>();

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", false);


services.AddApplication();
services.AddPersistence(configuration);

services.AddCors(opt =>
{
    opt.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
        policy.AllowAnyOrigin();
    });
});

var app = builder.Build();

app.UseMiddleware<FactoryCustomExceptionHandlerMiddleware>();


app.UseSwagger();
app.UseSwaggerUI(config =>
{
    config.RoutePrefix = string.Empty;
    config.SwaggerEndpoint("swagger/v1/swagger.json", "Refbooks API");
});

app.UseRouting();

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseResponseCaching();

app.UseAuthorization();

app.MapControllers();

app.Run();
