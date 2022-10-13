using Crud.Core.IRepositories;
using Crud.Core.IService;
using Crud.Repositories.Repositories;
using Crud.Service.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Utility
{
    public class DIResolver
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            //for accessing the http context by interface in view level
            #region Http context
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            #endregion
            //for service accesssing
            #region Service

            services.AddScoped<IDetailsServices, DetailsServices>();
            #endregion
            //for database accessing 
            #region Repository

            services.AddScoped<IDetailsRepository, DetailsRepository>();

            #endregion


        }
    }
}
