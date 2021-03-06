using Dmd.Domain.Interfaces;
using Dmd.Domain.Interfaces.Repository;
using Dmd.Infrastructure.Data.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dmd.Infrastructure.Data
{
    public static class ServiceRegistration
    {
        public static void AddInfrastuctureData(this IServiceCollection services, IConfiguration configuration)
        {
            // Регестрируем контекст
            services.AddDbContext<ApplicationContext>();
            #region Repositories
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));


            services.AddTransient<ICategoryRepositoryAsync, CategoryRepositoryAsync>();

            #endregion
        }
    }
}
