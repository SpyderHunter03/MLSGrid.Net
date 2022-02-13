using Microsoft.Extensions.DependencyInjection;

namespace MLSGrid
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddMLSGrid(this IServiceCollection services, string? apiKey = null, string? clientId = null, string? apiBase = null)
        {
            //TODO: Add potential configuration options for GridClient
            services.AddSingleton<IGridClient, GridClient>(g => new GridClient(apiKey, clientId, apiBase: apiBase));
            return services;
        }
    }
}
