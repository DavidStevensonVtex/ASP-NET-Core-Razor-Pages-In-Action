﻿// Listing 4.13 A parameter transformer that acts on a page route in the KebabPageRouteParameterTransformer.cs file in the CityBreaks folder

using System.Text.RegularExpressions;

namespace CityBreaks
{
    public class KebabPageRouteParameterTransformer
        : IOutboundParameterTransformer
    {
        public string? TransformOutbound(object? value)
        {
            if (value == null)
            {
                return null;
            }
            return Regex.Replace(value.ToString(), "([a-z]) ([A-Z])", "$1-$2");
        }
    }
}
