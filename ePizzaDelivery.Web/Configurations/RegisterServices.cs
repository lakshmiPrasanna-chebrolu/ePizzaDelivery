using ePizzaDelivery.Services.Implementations;
using ePizzaDelivery.Services.Interfaces;

namespace ePizzaDelivery.Web.Configurations
{
    public static class RegisterServices
    {
        public static IServiceCollection AddCustomServices(this IServiceCollection services)
        {
            // Register your interfaces and implementations here
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            return services;
        }
    }
}
