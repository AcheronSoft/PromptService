using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using PromptService.Api.Enums;
using PromptService.Api.Models.V1;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace PromptService.Api.Filters;

public class GeneratePromptRequestSchemaFilter(Dictionary<string, string> prompts) : ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        if (context.Type != typeof(GeneratePromptRequest)) return;

        schema.Example = new OpenApiObject
        {
            ["role"] = new OpenApiString(prompts["Role_Default"]),
            ["context"] = new OpenApiString(prompts["Context_Default"]),
            ["task"] = new OpenApiString(prompts["Task_Default"]),
            ["constraints"] = new OpenApiString(prompts["Constraints_Default"]),
            ["outputFormat"] = new OpenApiString(prompts["OutputFormat_Default"]),
            ["qualityCriteria"] = new OpenApiString(prompts["QualityCriteria_Default"]),
            ["commentLanguage"] = new OpenApiString(nameof(Language.English)),
            ["explainLanguage"] = new OpenApiString(nameof(Language.Russian))
        };
    }
}
