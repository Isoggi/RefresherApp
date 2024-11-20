using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RefresherApp.Application.Examples.DependencyInjections
{
    public static  class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
