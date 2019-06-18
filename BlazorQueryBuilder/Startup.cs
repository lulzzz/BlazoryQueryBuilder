using System.Collections.Generic;
using BlazorQueryBuilder.Models;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorQueryBuilder
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<List<Worker>>(new List<Worker>
            {
                new Worker {Uin = "820009398"},
                new Worker {Uin = "000000000"}
            });

            services.AddSingleton<PredicateFactory>();
            services.AddTransient(typeof(QueryBuilderService<>));
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
