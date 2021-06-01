using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Sep3.Authorization;
using Sep3.Data;
using Sep3.HttpServices;

namespace Sep3
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
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<IProofData, ProofDataService>();
            services.AddTransient<IUserService, UserWebService>();
            services.AddScoped<IBranchService, BranchWebService>();
            
            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
            
            services.AddAuthorization(options =>
            {
                options.AddPolicy("SecurityLevel2", a => a.RequireAuthenticatedUser().RequireClaim("role", "Admin"));
                
            });
            
            services.AddAuthorization(options =>
            {
                options.AddPolicy("SecurityLevel1", a => a.RequireAuthenticatedUser().RequireClaim("role", "User"));
            });
            
            services.AddHttpClient<IUserService, UserWebService>(client =>
                client.BaseAddress = new Uri("http://localhost:8080/"));
            
            /*services.AddHttpClient<IBranchService, BranchWebService>(client =>
                client.BaseAddress = new Uri("http://localhost:8080/"));*/

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
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}