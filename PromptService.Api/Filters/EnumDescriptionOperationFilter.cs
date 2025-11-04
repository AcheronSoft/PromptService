using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using PromptService.Api.Enums;
using PromptService.Api.Localization;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace PromptService.Api.Filters;

public class EnumDescriptionOperationFilter(IOptions<Options.Localization> localizationOptions) : IOperationFilter
{
    private readonly Dictionary<string, string> _prompts = StaticPrompts.GetDefaults(localizationOptions.Value.DefaultCulture);
    
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        foreach (var param in operation.Parameters)
        {
            param.Description = param.Name switch
            {
                "role" => _prompts["Role_Default"],
                "context" => _prompts["Context_Default"],
                "task" => _prompts["Task_Default"],
                "constraints" => _prompts["Constraints_Default"],
                "outputFormat" => _prompts["OutputFormat_Default"],
                "qualityCriteria" => _prompts["QualityCriteria_Default"],
                "commentLanguage" => nameof(Language.English),
                "explainLanguage" => nameof(Language.Russian),
                _ => param.Description
            };
        }
    }
}