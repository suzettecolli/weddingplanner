
using Application.Interfaces;
using Application.Services;

using Domain.Interfaces;

using Infrastructure.Persistence;
using Infrastructure.Persistence.DataMappers;
using Infrastructure.Persistence.Repositories;

using Microsoft.Extensions.DependencyInjection;

namespace ServiceCollections
{
    public static class CollectionExtensions
    {
        private static void AddCore(this IServiceCollection services)
        {

            services.AddScoped<IAppUserService, AppUserService>();
            services.AddScoped<IGuestManageService, GuestManageService>();
            services.AddScoped<IWedinngGiftManagerService, WedinngGiftManagerService>();
            services.AddScoped<IWedinngItineraryService, WedinngItineraryService>();
            
            services.AddScoped<IWedinngService, WedinngService>();

        }

        private static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<AppUserDataMapper>();
            services.AddTransient<WeddingDataMapper>();
            services.AddTransient<WeddingGiftDataMapper>();
            services.AddTransient<WeddingItineraryDataMapper>();
            services.AddTransient<WeddingParticipantDataMapper>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IAppUserRepository, AppUserRepository>();
            services.AddScoped<IWedinngGiftRepository, WedinngGiftRepository>();
            services.AddScoped<IWedinngItineraryRepository, WedinngItineraryRepository>();
            services.AddScoped<IWedinngRepository, WedinngRepository>();
            services.AddScoped<IWeddingParticipantRepository, WeddingParticipantRepository>();

            services.AddScoped<IRepositories, Repos>();
        }

        public static void AddWeddingPlanner(this IServiceCollection services)
        {
            services.AddCore();
            services.AddInfrastructure();
        }
    }
}
