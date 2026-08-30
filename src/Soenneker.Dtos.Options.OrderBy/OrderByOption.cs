using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Attributes.PublicOpenApiObject;
using Soenneker.Enums.SortDirections;

namespace Soenneker.Dtos.Options.OrderBy;

/// <summary>
/// Defines one field and direction used to order an API query result set.
/// </summary>
[PublicOpenApiObject]
public sealed class OrderByOption
{
    /// <summary>
    /// Serializable field name used for sorting; supported names are determined by the queried resource.
    /// </summary>
    [JsonPropertyName("field")]
    [JsonProperty("field")]
    public required string Field { get; set; }

    /// <summary>
    /// Sort direction for the field; when omitted, the API applies its documented default direction.
    /// </summary>
    [JsonPropertyName("direction")]
    [JsonProperty("direction")]
    public SortDirection? Direction { get; set; }
}
