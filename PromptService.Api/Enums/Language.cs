using System.ComponentModel;

namespace PromptService.Api.Enums;

/// <summary>
/// Languages with localization support.
/// </summary>
public enum Language
{
    [Description("English")]
    English,

    [Description("Русский")]
    Russian,

    [Description("Español")]
    Spanish,

    [Description("中文 (简体)")]
    ChineseSimplified,

    [Description("中文 (繁體)")]
    ChineseTraditional,

    [Description("Deutsch")]
    German,

    [Description("Français")]
    French,

    [Description("Português")]
    Portuguese,

    [Description("Italiano")]
    Italian,

    [Description("日本語")]
    Japanese,

    [Description("한국어")]
    Korean,

    [Description("हिन्दी")]
    Hindi,

    [Description("العربية")]
    Arabic,

    [Description("Türkçe")]
    Turkish,

    [Description("Polski")]
    Polish,

    [Description("Українська")]
    Ukrainian,

    [Description("Nederlands")]
    Dutch,

    [Description("עברית")]
    Hebrew
}
