using Microsoft.Extensions.Options;
using PromptService.Api.Filters;
using PromptService.Api.Localization;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace PromptService.Api.Configuration;

/// <summary>
/// Configures Swagger/OpenAPI generation options.
/// </summary>
public class ConfigureSwaggerOptions(IOptions<Options.Localization> localizationOptions) : IConfigureOptions<SwaggerGenOptions>
{
    public void Configure(SwaggerGenOptions options)
    {
        // Add XML comments to Swagger UI
        var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
        options.IncludeXmlComments(xmlPath, includeControllerXmlComments: true);

        var defaultPrompts = StaticPrompts.GetDefaults(localizationOptions.Value.DefaultCulture);

        // Add schema filters
        options.SchemaGeneratorOptions.SchemaFilters.Add(new GeneratePromptRequestSchemaFilter(defaultPrompts));
        options.SchemaGeneratorOptions.SchemaFilters.Add(new EnumDescriptionSchemaFilter());
    }
}
