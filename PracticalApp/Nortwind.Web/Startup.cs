using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Nortwind.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (!env.IsDevelopment())
            {
                app.UseHsts();
            }
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();

                endpoints.MapGet("/", context =>
                {
                    context.Response.Redirect("Suppliers"); // Перенаправить на Index.cshtml
                    return Task.CompletedTask;
                });  

                endpoints.MapGet("/hello", () => "Hello World!");
            });
        }
    }
}

