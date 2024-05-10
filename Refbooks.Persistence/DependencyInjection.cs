using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refbooks.Application.Interfaces;
using Refbooks.Persistence.Updater;

namespace Refbooks.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services,
            IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnectionString");
            if(string.IsNullOrEmpty(connectionString))
                throw new NotImplementedException("DefaultConnectionString - is not declared.");

            services.AddDbContextFactory<RefbooksDbContext>(opt =>
               opt.UseNpgsql(connectionString)
                .UseSnakeCaseNamingConvention()
            );

            services.AddScoped<IRefbooksDbContext, RefbooksDbContext>();

            services.AddSingleton<IRefbooksDbContextFactory, RefbooksDbContextFactory<RefbooksDbContext>>();

            services.AddHostedService<RefbooksDbMigrationHostedService>();

            services.AddScoped<IRefbookUpdater, RefbooksUpdater>(x =>
            {
                var baseXmlRefbookFilesPath = configuration.GetRequiredSection("XmlRefbooksPath").Get<string>() ?? string.Empty;
                var contextFactory = x.GetRequiredService<IRefbooksDbContextFactory>();

                return new RefbooksUpdater(contextFactory, baseXmlRefbookFilesPath);
            });

            return services;
        }
    }
}
