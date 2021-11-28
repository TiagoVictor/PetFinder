using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PetDiscovery.Dependency;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetDiscovery
{
    class StartUp
    {
        public StartUp(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get;}

        public void ConfigurationServices(IServiceCollection services)
        {
            var conexaoPostgre = Configuration.GetConnectionString("DefaultConnection");

            services.AddNHibernate(conexaoPostgre);
        }

    }
}
