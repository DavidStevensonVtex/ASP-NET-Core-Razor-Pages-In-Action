using System.Text.RegularExpressions;

namespace CityBreaks.ParameterTransformers
{
    public class KebabPageRouteParameterTransformer : IOutboundParameterTransformer
    {
        public string? TransformOutbound(object? value)
        {
            if (value == null)
            {
                return null;
            }
#pragma warning disable CS8604
            return Regex.Replace(value.ToString(), "([a-z])([A-Z])", "$1-$2");
        }
    }
}
