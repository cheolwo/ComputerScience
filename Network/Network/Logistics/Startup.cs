using Logistics.Areas.Identity;
using Logistics.Data;
using Market.IDataManager.ofSCommodity;
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
using Market;
using Market.DataManager.ofSCommodity;
using Warehouse;
using Warehouse.DataManager;
using Warehouse.IDataManager;
using Logistics.Service;

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
            //services.AddDbContext<TCommodityDataContext>(options =>
            //   options.UseSqlServer(
            //       Configuration.GetConnectionString("CommodityConnection")));
            services.AddDbContext<WCommodityDataContext>(options =>
              options.UseSqlServer(
                  Configuration.GetConnectionString("WCommodityConnection")));
            services.AddDbContext<SCommodityDataContext>(options =>
              options.UseSqlServer(
                  Configuration.GetConnectionString("SCommodityConnection")));

            services.AddSingleton<HttpClient>();
            services.AddHttpClient();
            services.AddHttpContextAccessor();
            // services.AddHttpClient("Coupang", c =>
            // {
            //     c.BaseAddress = new Uri("https://api-gateway.coupang.com/");
            // });

            services.AddTransient<ISCommodityManager, SCommodityManager>();
            services.AddTransient<IDetailofSCommodityManager, DetailofSCommodityManager>();
            services.AddTransient<IOptionManager, OptionManager>();
            services.AddTransient<IImageofDetailManager, ImageofDeatilManager>();
            services.AddTransient<IImageofOptionManager, ImageofOptionManager>();
            services.AddTransient<IDocofSCommodityManager, DocofSCommodityManager>();
            services.AddTransient<IDetailImageManager, DetailImageManager>();
            
            services.AddTransient<IBaseManager, BaseManager>();
            services.AddTransient<IWCommodityManager, WCommodityManager>();
            services.AddTransient<IDividedCommodityManager, DividedCommodityManager>();
            services.AddTransient<IOutgoingCommodityManager, OutgoingCommodityManager>();
            services.AddTransient<IPackManager, PackManager>();
            services.AddTransient<IImageofPackManager, ImageofPackManager>();
            services.AddTransient<IIncomingTagManager, IncomingTagManager>();
            services.AddTransient<IDividedTagManager, DividedTagManager>();
            services.AddTransient<ILoadFrameManager, LoadFrameManager>();
            services.AddTransient<IImageofWCommodityManager, ImageofWCommodityManager>();
            services.AddTransient<IImageofIncomingManager, ImageofIncomingManager>();
            services.AddTransient<IImageofLoadingManager, ImageofLoadingManager>();
            services.AddTransient<IImageofOutgoingManager, ImageofOutgoingManager>();
            services.AddTransient<IImageofLoadingManager, ImageofLoadingManager>();
                          
            services.AddScoped<ISCommodityFileManager, SCommodityFileManager>();
            services.AddTransient<IWarehouseFileManager, WarehouseFileManager>();

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
