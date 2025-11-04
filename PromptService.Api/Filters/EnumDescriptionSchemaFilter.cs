using System.ComponentModel;
using System.Reflection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using PromptService.Api.Enums;
using PromptService.Api.Localization;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace PromptService.Api.Filters;

public class EnumDescriptionSchemaFilter : ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        if (!context.Type.IsEnum) 
            return;
        
        var descriptions = new List<string>();

        foreach (var field in context.Type.GetFields(BindingFlags.Public | BindingFlags.Static))
        {
            var name = field.Name;
            var description = field.GetCustomAttribute<DescriptionAttribute>()?.Description;
            descriptions.Add($"{name} = {description}");
        }

        schema.Description += Environment.NewLine + string.Join(Environment.NewLine, descriptions);
    }
}