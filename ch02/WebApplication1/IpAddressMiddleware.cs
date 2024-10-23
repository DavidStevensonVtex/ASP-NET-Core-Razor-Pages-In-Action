// Listing 2.14 Middleware class based on the convention-based approach in IpAddressMiddleware.cs file in WebApplication1 folder.

namespace WebApplication1
{
	public class IpAddressMiddleware
	{
		private readonly RequestDelegate _next;
		public IpAddressMiddleware(RequestDelegate next) => _next = next;

		public async Task InvokeAsync(HttpContext context, ILogger<IpAddressMiddleware> logger)
		{
			var ipAddress = context.Connection.RemoteIpAddress;
			logger.LogInformation($"Visitor is from {ipAddress}");
			await _next(context);
		}
	}
}
