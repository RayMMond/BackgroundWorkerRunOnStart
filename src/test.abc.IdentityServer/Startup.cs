using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace test.abc
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<abcIdentityServerModule>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.InitializeApplication();
        }
    }
}
