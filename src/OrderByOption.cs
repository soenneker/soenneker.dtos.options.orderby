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
    [JsonPropertyName("field")]
    [JsonProperty("field")]
    public string Field { get; set; } = null!;

    [JsonPropertyName("direction")]
    [JsonProperty("direction")]
    public SortDirection? Direction { get; set; }
}