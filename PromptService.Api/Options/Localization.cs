using PromptService.Api.Enums;

namespace PromptService.Api.Options;

public class Localization
{
    public List<Culture> SupportedCultures { get; set; }
    public Culture DefaultCulture { get; set; }

}