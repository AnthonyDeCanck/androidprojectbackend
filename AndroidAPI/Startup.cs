using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AndroidAPI.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace AndroidAPI
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            string connection = Environment.GetEnvironmentVariable("MYSQLCONNSTR_localdb");
            string dbhost = Regex.Match(connection, @"Data Source=(.+?);").Groups[1].Value;
            string server = dbhost.Split(':')[0].ToString();
            string port = dbhost.Split(':')[1].ToString();
            string dbname = Regex.Match(connection, @"Database=(.+?);").Groups[1].Value;
            string dbusername = Regex.Match(connection, @"User Id=(.+?);").Groups[1].Value;
            string dbpassword = Regex.Match(connection, @"Password=(.+?)$").Groups[1].Value;

            string connstring = $@"server={server};userid={dbusername};password={dbpassword};database={dbname};port={port};pooling = false; convert zero datetime=True;";
            services.AddDbContext<DataContext>(options =>
            options.UseMySql(connstring));
            //options.UseMySql(Configuration.GetConnectionString("Context")));

            services.AddScoped<DataContext>();

            services.AddCors(options =>
                    options.AddPolicy("AllowAllOrigins", builder =>
                    builder.AllowAnyOrigin()));

            services.AddScoped<MessageRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.UseHttpsRedirection();
            app.UseCors("AllowAllOrigins");
            var serviceScopeFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();
            using (var serviceScope = serviceScopeFactory.CreateScope())
            {
                var dbContext = serviceScope.ServiceProvider.GetService<DataContext>();
                dbContext.Database.EnsureDeleted();

                dbContext.Database.EnsureCreated();
            }
        }
    }
}
