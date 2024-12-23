﻿// Listing 4.5 The custom CityRouteConstraint class in the CityRouteConstraint.cs in the CityBreaks/RouteConstraints folder.

namespace CityBreaks.RouteConstraints
{
	public class CityRouteConstraint : IRouteConstraint
	{
		public bool Match(
			HttpContext httpContext,
			IRouter route,
			string routeKey,
			RouteValueDictionary values,
			RouteDirection routeDirection)
		{
			var cities = new[] { "amsterdam", "barcelona", "berlin",
				"copehagen", "dubrovnik", "ediburgh", "london", "madrid",
				"paris", "rome", "venice" };

			return cities.Contains(values[routeKey]?.ToString().ToLowerInvariant());
		}
	}
}
