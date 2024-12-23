﻿// Listing 4.16 Transforming spaces into hyphens within a route parameter value in SlugParameterTransformer.cs in the CityBreaks folder

namespace CityBreaks
{
    public class SlugParameterTransformer : IOutboundParameterTransformer
    {
        public string? TransformOutbound(object? value)
        {
            return value?.ToString().Replace(" ", "-");
        }
    }
}
