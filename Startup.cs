using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TF_FinanzasBackEnd.Persistence;
using TF_FinanzasBackEnd.Services;
using TF_FinanzasBackEnd.Services.Impl;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;



namespace TF_Finanzas
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddTransient<DescuentoService, DescuentoServiceImpl>();
            services.AddTransient<UsuarioService, UsuarioServiceImpl>();
            services.AddTransient<LetraService, LetraServiceImpl>();
            services.AddTransient<GiradorService, GiradorServiceImpl>();

                    



            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                     builder => builder.AllowAnyOrigin()
                     .AllowAnyMethod()
                     .AllowAnyHeader());
            });


            var connectionString = "Server=localhost;Database=TF-Finanzas;User=root;Password=1930063057198aL;";
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 25));

            services.AddDbContextPool<ApplicationDbContext>(
                DbContextOptions => DbContextOptions.UseMySql(connectionString, serverVersion).EnableSensitiveDataLogging()
                .EnableDetailedErrors());

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "TF_Finanzas",
                    Version = "v1"
                });
            });

            services.AddAutoMapper(typeof(Startup));

        }

       

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors("CorsPolicy");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "TF_Finanzas");
            });

        }
    }
}
