using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Refbooks.Application.Interfaces;

namespace Refbooks.Persistence
{
    public class RefbooksDbMigrationHostedService : IHostedService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<RefbooksDbMigrationHostedService> _logger;
        public RefbooksDbMigrationHostedService(IServiceProvider serviceProvider,
            ILogger<RefbooksDbMigrationHostedService> logger)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
        }
        public async Task StartAsync(CancellationToken cancellationToken)
        {
            using var scope = _serviceProvider.CreateScope();
            var contextFactory = scope.ServiceProvider.GetRequiredService<IRefbooksDbContextFactory>();

            using(var context = await contextFactory.CreateDbContextAsync(cancellationToken))
            {
                var hasNewMigrations = (await context.Database.GetPendingMigrationsAsync()).Any();

                if (hasNewMigrations)
                {
                    _logger.LogInformation("Применение миграций");
                    await context.Database.MigrateAsync();
                }
                else
                {
                    _logger.LogInformation("Новых миграций нет");
                }
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
