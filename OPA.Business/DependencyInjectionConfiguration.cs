using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OPA.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace OPA.Business
{
    static class Configuration
    {
        public static IServiceCollection RegisterServices(this IServiceCollection container, IConfiguration configuartion)
        {
            container.AddTransient<IOrder, PhysicalProduct>();
            container.AddTransient<IAgent, Agent>();
            container.AddTransient<IEmailManager, EmailManager>();

            return container;
        }
    }
}
