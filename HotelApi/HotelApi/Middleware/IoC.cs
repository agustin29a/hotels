using HotelApi.Repositories.Interfaces;
using HotelApi.Repositories;
using HotelApi.Services;
using HotelApi.Services.Interfaces;
using HotelApi.Core.Mapper;

namespace HotelApi.Middleware
{
    public static class IoC
    {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
            services.AddScoped<IHotelRepository, HotelRepository>();
            services.AddScoped<IHotelService, HotelService>();
            services.AddAutoMapper(typeof(EntityMapper));

            return services;
        }
    }
}
