using Contracts;
using LoggerService;
using Service.Contracts;

namespace KEBZ_Communications.WebAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                {
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                });
            });
        }

        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
        }
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }
        //public static void ConfigureRepositoryManager(this IServiceCollection services)
        public static void ConfigureServiceManager(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, IServiceManager>();
        }
        //public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        //{
        //    services.AddDbContext<RepositoryContext>(opts =>
        //                   opts.UseSqlServer(configuration.GetConnectionString("sqlConnection"), b =>
        //                                      b.MigrationsAssembly("KEBZ_Communications.WebAPI")));
        //}

    }

}
