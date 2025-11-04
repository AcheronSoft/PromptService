using System.Text.Json.Serialization;
using PromptService.Api.Enums;

namespace PromptService.Api.Models.V1;

public class GeneratePromptRequest
{
    [JsonPropertyName("role")]
    public string Role { get; set; } = string.Empty;

    [JsonPropertyName("context")] 
    public string Context { get; set; } = string.Empty;

    [JsonPropertyName("task")] 
    public string Task { get; set; } = string.Empty;

    [JsonPropertyName("constraints")] 
    public string Constraints { get; set; } = string.Empty;

    [JsonPropertyName("outputFormat")] 
    public string OutputFormat { get; set; } = string.Empty;

    [JsonPropertyName("qualityCriteria")] 
    public string QualityCriteria { get; set; } = string.Empty;
    
    [JsonPropertyName("commentLanguage")]
    public Language CommentLanguage { get; set; } = Language.English;
    
    [JsonPropertyName("explainLanguage")]
    public Language ExplainLanguage { get; set; } = Language.Russian;
}