using PromptService.Api.Enums;
using PromptService.Api.Extensions;
using PromptService.Api.Options;

namespace PromptService.Api.Localization;

public static class StaticPrompts
{
    private static readonly Dictionary<string, string> EnglishPrompts = new()
    {
        ["Role_Default"] = "I'm Senior Backend Developer .NET.",
        ["Context_Default"] = "Context: [briefly describe the project, situation, or goal].",
        ["Task_Default"] = "Task: [clearly formulate what exactly needs to be obtained].",
        ["Constraints_Default"] = "Constraints: [what is not allowed, requirements for technologies, style, format].",
        ["OutputFormat_Default"] = "Output Format: [in what form the result is needed - code, table, list, JSON, markdown, etc.].",
        ["QualityCriteria_Default"] = "Quality Criteria: [by what signs do you consider the result 'successful']."
    };

    private static readonly Dictionary<string, string> RussianPrompts = new()
    {
        ["Role_Default"] = "Я Senior Backend Developer .NET.",
        ["Context_Default"] = "Контекст: [опиши кратко проект, ситуацию или цель].",
        ["Task_Default"] = "Задача: [чётко сформулируй, что именно нужно получить].",
        ["Constraints_Default"] = "Ограничения: [что нельзя, требования по технологиям, стилю, формату].",
        ["OutputFormat_Default"] = "Формат ответа: [в каком виде нужен результат - код, таблица, список, JSON, markdown и т.д.].",
        ["QualityCriteria_Default"] = "Критерии качества: [по каким признакам ты считаешь, что результат 'успешный']."
    };

    private static readonly Dictionary<Language, Dictionary<string, string>> Prompts;

    static StaticPrompts()
    {
        Prompts = new Dictionary<Language, Dictionary<string, string>>
        {
            [Language.English] = EnglishPrompts,
            [Language.Russian] = RussianPrompts
        };

        // All other languages will default to English
        foreach (Language lang in Enum.GetValues(typeof(Language)))
        {
            Prompts.TryAdd(lang, EnglishPrompts);
        }
    }

    public static Dictionary<string, string> GetDefaults(Culture culture)
    {
        var language = culture.ToLanguage();
        var prompts = Prompts[language];
        return prompts;
    }
}
