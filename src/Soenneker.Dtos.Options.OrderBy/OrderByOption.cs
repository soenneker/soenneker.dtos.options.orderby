using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Attributes.PublicOpenApiObject;
using Soenneker.Enums.SortDirections;

namespace Soenneker.Dtos.Options.OrderBy;

/// <summary>
/// An object for ordering during querying
/// </summary>
[PublicOpenApiObject]
public sealed class OrderByOption
{
    /// <summary>
    /// The field to sort by.
    /// </summary>
    [JsonPropertyName("field")]
    [JsonProperty("field")]
    public string Field { get; set; } = null!;

    /// <summary>
    /// The direction to sort the field by.
    /// </summary>
    [JsonPropertyName("direction")]
    [JsonProperty("direction")]
    public SortDirection? Direction { get; set; }
}
