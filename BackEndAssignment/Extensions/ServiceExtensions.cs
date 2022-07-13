using BackEndAssignment.Context;
using BackEndAssignment.Interfaces.Repositories;
using BackEndAssignment.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.OpenApi.Models;

namespace BackEndAssignment.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddSwaggerExtension(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Library API"
                });
            });
        }




        internal static void AddEntityFramework(IServiceCollection services)
        {
            //Read the connection db from the appsettings.
            services.AddDbContext<ApplicationDbContext>();
        }

        public static void AddBaseServiceExtension(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
        }

        public static void AddApiVersioningExtension(this IServiceCollection services)
        {
            services.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.ReportApiVersions = true;
            });
        }


        public static void AddRepositoriesExtension(this IServiceCollection services)
        {
            services.AddTransient(typeof(IBaseRepositoryAsync<>), typeof(BaseRepositoryAsync<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IAuthorsRepository, AuthorsRepository>();

            /*
             TODO:
                - Add your individual repositories to use them as DI
             */


        }
    }
}
