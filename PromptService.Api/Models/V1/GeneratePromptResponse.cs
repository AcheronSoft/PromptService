using PromptService.Api.Enums;

namespace PromptService.Api.Models.V1;

public class GeneratePromptResponse
{
    public string Role { get; set; }
    public string Context { get; set; }
    public string Task { get; set; }
    public string Constraints { get; set; }
    public string OutputFormat { get; set; }
    public string QualityCriteria { get; set; }
    public Language CommentLanguage { get; set; }
    public Language ExplainLanguage { get; set; }
    public string Comment { get; set; } = "Сгенерируй решение в соответствии с этими параметрами.";
}