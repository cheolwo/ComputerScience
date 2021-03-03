using Import.DataManager;
using Import.ImportDataContext;
using Logistics.Areas.Identity;
using Logistics.Data;
using Logistics.Pages.ofOption;
using Logistics.Service;
using MatBlazor;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Net.Http;

namespace Logistics
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("IdentityConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddDbContext<CommotityDataContext>(options =>
               options.UseSqlServer(
                   Configuration.GetConnectionString("CommodityConnection")));

            services.AddSingleton<HttpClient>();
            services.AddTransient<ICommodityManager, CommodityManager>();
            services.AddTransient<ICommodityDetailManager, CommodityDetailManager>();
            services.AddTransient<IOptionManager, OptionManager>();
            services.AddTransient<IImageofDetailManager, ImageofDeatilManager>();
            services.AddTransient<IImageofOptionManager, ImageofOptionManager>();
            services.AddTransient<Create>();
            services.AddSingleton<Get>();

            services.AddScoped<IFileManager, FileManager>();
            services.AddScoped<IMatFileManager, MatFileManager>();
            services.AddScoped<ICommodityFileManager, CommodityFileManager>();

            services.AddMatBlazor();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
            services.AddSingleton<WeatherForecastService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
