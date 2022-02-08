using FakeXiechengAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FakeXiechengAPI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // 注意：所有的 内置的服务都是在这边添加的
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            // 相当添加了一个 service
            services.AddTransient<ITouristRouteRepo, MockTouristRouteRepo>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // 这个是用来接收请求的，比如：路由，中间件，等等
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // endpoints.MapGet("/",
                //     async context => { await context.Response.WriteAsync("Hello World!"); });
                // endpoints.MapGet("/test",
                //     async context =>
                //     {
                //         // throw new Exception("test exception");
                //         await context.Response.WriteAsync("Hello World from test!");
                //     });

                endpoints.MapControllers();
            });
        }
    }
}