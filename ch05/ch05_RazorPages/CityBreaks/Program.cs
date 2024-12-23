// Listing 4.17 Using SlugParameterTransformer in Program.cs file in the CityBreaks folder

using CityBreaks.RouteConstraints;
using CityBreaks.PageRouteModelConventions;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace CityBreaks
{
    public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddRazorPages()
				.AddRazorPagesOptions(options =>
			{
					options.Conventions.AddPageRoute("/Index", "FindMe");
					options.Conventions.Add(new CultureTemplatePageRouteModelConvention());
					options.Conventions.Add(new PageRouteTransformerConvention(
						new KebabPageRouteParameterTransformer()));
				});

			builder.Services.Configure<RouteOptions>(options =>
			{
                options.LowercaseUrls = true;
                options.ConstraintMap.Add("city", typeof(CityRouteConstraint));
				options.ConstraintMap.Add("slug", typeof(SlugParameterTransformer)); // city: New York => new-york
			});

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.MapRazorPages();

			app.Run();
		}
	}
}
