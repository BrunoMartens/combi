using Combi.Dal.Repositories;
using Combi.Dal.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi.Dal.Configuration
{
    public static class ServicesConfiguration
    {
        public static void AddCombiDal(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<CombiDbContext>(options => options.UseSqlServer(connectionString));

            services.AddTransient<IDemoRepository, DemoRepository>();
        }
    }
}
