// Listing 2.16 Refactoring IpAddressMiddleware to use IMiddleware in IpAddressMiddleware.cs file in WebApplication1 folder.

namespace WebApplication1
{
	public class IpAddressMiddleware : IMiddleware
	{
		ILogger<IpAddressMiddleware> _logger;

		public IpAddressMiddleware(ILogger<IpAddressMiddleware> logger) => _logger = logger;


		public async Task InvokeAsync(HttpContext context, RequestDelegate next)
		{
			var ipAddress = context.Connection.RemoteIpAddress;
			_logger.LogInformation($"Visitor is from {ipAddress}");
			await next(context);
		}
	}
}
