// Listing 2.15b Registering middleware with an extension method in the Program.cs file in the WebApplication1 folder.

namespace WebApplication1
{
	public static class Extensions
	{
		public static IApplicationBuilder UseIpAddressMiddleware(this IApplicationBuilder app)
		{
			return app.UseMiddleware<IpAddressMiddleware>();
		}
	}
}
