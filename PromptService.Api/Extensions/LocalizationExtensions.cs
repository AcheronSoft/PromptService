using PromptService.Api.Enums;
using PromptService.Api.Options;

namespace PromptService.Api.Extensions;

public static class LocalizationExtensions
{
    public static Language ToLanguage(this Culture defaultCulture)
    {
        return defaultCulture.Name switch
        {
            nameof(Language.English) => Language.English,
            nameof(Language.Russian) => Language.Russian,
            nameof(Language.Spanish) => Language.Spanish,
            nameof(Language.ChineseSimplified) => Language.ChineseSimplified,
            nameof(Language.ChineseTraditional) => Language.ChineseTraditional,
            nameof(Language.German) => Language.German,
            nameof(Language.French) => Language.French,
            nameof(Language.Portuguese) => Language.Portuguese,
            nameof(Language.Italian) => Language.Italian,
            nameof(Language.Japanese) => Language.Japanese,
            nameof(Language.Korean) => Language.Korean,
            nameof(Language.Hindi) => Language.Hindi,
            nameof(Language.Arabic) => Language.Arabic,
            nameof(Language.Turkish) => Language.Turkish,
            nameof(Language.Polish) => Language.Polish,
            nameof(Language.Ukrainian) => Language.Ukrainian,
            nameof(Language.Dutch) => Language.Dutch,
            nameof(Language.Hebrew) => Language.Hebrew,
            _ => throw new ArgumentException("Unknown culture")
        };
    }
}