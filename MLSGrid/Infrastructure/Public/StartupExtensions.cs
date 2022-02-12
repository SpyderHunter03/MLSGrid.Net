using Microsoft.Extensions.DependencyInjection;

namespace MLSGrid
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddMLSGrid(this IServiceCollection services)
        {
            //TODO: Add potential configuration options for GridClient
            services.AddSingleton<IGridClient, GridClient>(g => new GridClient());
            return services;
        }
    }
}
