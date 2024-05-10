using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace Refbooks.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection servises)
        {
            servises.AddMediatR(opt 
                => opt.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            return servises;
        }
    }
}
