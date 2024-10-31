using CityBreaks.ParameterTransformers;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages(options => {
    options.Conventions.Add(new PageRouteTransformerConvention(new KebabPageRouteParameterTransformer()));
});

builder.Services.Configure<RouteOptions>(options =>
{
    options.LowercaseUrls = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapGet("/", () => "Hello World!");

app.Run();
