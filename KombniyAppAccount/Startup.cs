using KombiyApp.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KombniyApp.Services;
using KombniyApp.Core.Services;
using KombniyApp.Core.Repository;
using KombiyApp.Data.Repository;
using FluentValidation;
using FluentValidation.Validators;
using FluentValidation.AspNetCore;
using KombniyApp.Core;
using KombniyAppAccount.Validation;
using KombniyAppAccount.Models;
using KombniyAppAccount.PaymentServices;
using Stripe;
using KombinyAPP.MapConfig.ConfigProfile;
using Microsoft.Extensions.Logging;

namespace KombniyAppAccount
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
			MapperConfig.RegisterMapper();
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			ConfigureStripe();
			services.AddAuthentication("CookieAuthentication")
				.AddCookie("CookieAuthentication", config =>
				 {
					 config.Cookie.Name = "UserLoginCokie";
					 config.LoginPath = "/Index";
					 config.AccessDeniedPath = "/AccessDefined";
				 });
			
			services.AddControllersWithViews();
			services.AddDistributedMemoryCache();
			services .AddScoped<IImage, ImageService>();
			services.AddScoped<ICardPaymentServices, CardPaymentServices>();
			services.AddTransient<IUnitOfWork, UnitOfWork>();
			services.AddTransient<IUser, UserServices>();
			services.AddSession(options =>
			{
				options.Cookie.HttpOnly = true;
				options.Cookie.IsEssential = true;
			});
			services.AddDbContext<AppDbContext>(options=> options.UseSqlServer(Configuration.GetConnectionString("KombniyAppConnection")));

			services.AddControllersWithViews().AddFluentValidation();
			services.AddTransient<IValidator<User>, UserValidator>();
			services.AddTransient<IValidator<UserLoginViewModels>, UserLoginValidator>();
		}

		private void ConfigureStripe()
		{
			var stripeApiKey = Configuration["Stripe:ApiKey"];

			StripeConfiguration.SetApiKey(stripeApiKey);
		}
		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			

			Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzgyMjE5QDMxMzgyZTM0MmUzMFFOQzA3MDcwS2krS3cxbGE3SStQK1YvVjJQcTVrWFFlc3I3Y0lhM241Z1U9");
			
			
			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseSession();
		
			app.UseRouting();

			app.UseAuthorization(); 

			

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Account}/{action=Index}/{id?}");
			});
		}
	}
}
