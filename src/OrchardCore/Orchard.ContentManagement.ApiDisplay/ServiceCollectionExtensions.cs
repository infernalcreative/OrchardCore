using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Orchard.JsonApi.Filters;

namespace Orchard.JsonApi
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApiContentManagementDisplay(this IServiceCollection services)
        {
            services.Configure<MvcOptions>((options) =>
            {
                options.Filters.Add(typeof(JsonApiFilter));
            });

            services.TryAddScoped<IApiContentManager, ApiContentManager>();

            return services;
        }
    }
}