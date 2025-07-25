using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Enums.SortDirections;

namespace Soenneker.Dtos.Options.OrderBy;

/// <summary>
/// An object for ordering during querying
/// </summary>
public sealed class OrderByOption
{
    [JsonPropertyName("field")]
    [JsonProperty("field")]
    public string Field { get; set; } = null!;

    [JsonPropertyName("direction")]
    [JsonProperty("direction")]
    public SortDirection? Direction { get; set; }
}