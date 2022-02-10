using EveVoid.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using IO.Swagger.Api;
using EveVoid.Services;
using EveVoid.Services.EveObjects;
using EveVoid.Services.Pilots;
using EveVoid.Services.Navigation.MapObjects;
using EveVoid.Services.Navigation;
using AutoMapper;
using System.Reflection;
using System.Linq;
using System;

namespace EveVoid
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        private string AllowAllCorsPolicy = "AllowAllCorsPolicy";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            if (Configuration.GetValue<string>("SqlProvider") == "SqlServer")
            {
                services.AddDbContext<EveVoidContext>(options =>
                    options.UseLazyLoadingProxies().UseSqlServer(Configuration.GetConnectionString("SqlServerConnectionString")));
            }
            if (Configuration.GetValue<string>("SqlProvider") == "MySql")
            {
                services.AddDbContext<EveVoidContext>(options =>
                    options.UseLazyLoadingProxies().UseMySql(Configuration.GetConnectionString("MySqlConnectionString")));
            }
            services.AddScoped<ICharacterApi, CharacterApi>();
            services.AddScoped<ICharacterService, CharacterService>();
            services.AddScoped<IAllianceApi, AllianceApi>();
            services.AddScoped<IAllianceService, AllianceService>();
            services.AddScoped<ICorporationApi, CorporationApi>();
            services.AddScoped<ICorporationService, CorporationService>();
            services.AddScoped<IUniverseApi, UniverseApi>();
            services.AddScoped<IItemTypeService, ItemTypeService>();
            services.AddScoped<IItemGroupService, ItemGroupService>();
            services.AddScoped<IItemCategoryService, ItemCategoryService>();
            services.AddScoped<IConstellationService, ConstellationService>();
            services.AddScoped<IRegionService, RegionService>();
            services.AddScoped<IStargateService, StargateService>();
            services.AddScoped<ISolarSystemService, SolarSystemService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<ILocationApi, LocationApi>();
            services.AddScoped<ISignatureService, SignatureService>();
            services.AddScoped<ITagService, TagService>();
            services.AddScoped<ISolarSystemStructureService, SolarSystemStructureService>();
            services.AddScoped<ISolarSystemNoteService, SolarSystemNoteService>();
            services.AddScoped<IRouteService, RouteService>();
            services.AddScoped<IDscanService, DscanService>();
            services.AddScoped<IPilotService, PilotService>();

            var mapperConfig = new MapperConfiguration(mc =>
            {
                var profiles = Assembly.GetExecutingAssembly().GetTypes().Where(x => typeof(Profile).IsAssignableFrom(x));
                foreach (var profile in profiles)
                {
                    mc.AddProfile(Activator.CreateInstance(profile) as Profile);
                }
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
            services.AddSwaggerGen();

            services.AddSignalR();

            services.AddCors(options =>
            {
                options.AddPolicy(name: AllowAllCorsPolicy,
                                  options =>
                                  {
                                      options.AllowAnyOrigin()
                                      .AllowAnyMethod()
                                      .AllowAnyHeader();
                                  });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            if (!env.IsDevelopment())
            {
                app.UseSpaStaticFiles();
            }
            app.UseSwagger(c =>
            {
                c.SerializeAsV2 = true;
            });
            app.UseRouting();

            if (env.IsDevelopment())
            {
                app.UseCors(AllowAllCorsPolicy);
            }

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "EveVoid API v1");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                //if (env.IsDevelopment())
                //{
                //    spa.UseAngularCliServer(npmScript: "start");
                //}
            });
        }
    }
}
