using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OPA.Abstraction;
using OPA.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApplication
{
    public class Startup
    {
        IConfigurationRoot Configuration { get; }

        public Startup()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging();
            services.AddSingleton<IConfigurationRoot>(Configuration);
            services.AddSingleton<IAgent, Agent>();
        }
    }
}
