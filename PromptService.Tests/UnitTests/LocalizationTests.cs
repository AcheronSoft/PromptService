using PromptService.Api.Enums;
using PromptService.Api.Extensions;
using PromptService.Api.Localization;

namespace PromptService.Tests.UnitTests;

public class LocalizationTests
{
    [Theory]
    [InlineData("English", Language.English)]
    [InlineData("Russian", Language.Russian)]
    [InlineData("Spanish", Language.Spanish)]
    [InlineData("ChineseSimplified", Language.ChineseSimplified)]
    [InlineData("ChineseTraditional", Language.ChineseTraditional)]
    [InlineData("German", Language.German)]
    [InlineData("French", Language.French)]
    [InlineData("Portuguese", Language.Portuguese)]
    [InlineData("Italian", Language.Italian)]
    [InlineData("Japanese", Language.Japanese)]
    [InlineData("Korean", Language.Korean)]
    [InlineData("Hindi", Language.Hindi)]
    [InlineData("Arabic", Language.Arabic)]
    [InlineData("Turkish", Language.Turkish)]
    [InlineData("Polish", Language.Polish)]
    [InlineData("Ukrainian", Language.Ukrainian)]
    [InlineData("Dutch", Language.Dutch)]
    [InlineData("Hebrew", Language.Hebrew)]
    public void ToLanguage_ConvertsCultureNameToLanguageEnumCorrectly(string cultureName, Language expectedLanguage)
    {
        // Act
        var actualLanguage = cultureName.ToLanguage();

        // Assert
        Assert.Equal(expectedLanguage, actualLanguage);
    }

    [Theory]
    [InlineData("English")]
    [InlineData("Russian")]
    [InlineData("Spanish")]
    [InlineData("ChineseSimplified")]
    [InlineData("ChineseTraditional")]
    [InlineData("German")]
    [InlineData("French")]
    [InlineData("Portuguese")]
    [InlineData("Italian")]
    [InlineData("Japanese")]
    [InlineData("Korean")]
    [InlineData("Hindi")]
    [InlineData("Arabic")]
    [InlineData("Turkish")]
    [InlineData("Polish")]
    [InlineData("Ukrainian")]
    [InlineData("Dutch")]
    [InlineData("Hebrew")]
    public void GetDefaults_ReturnsCorrectPromptsForSupportedCultures(string cultureName)
    {
        // Act
        var prompts = StaticPrompts.GetDefaults(cultureName);

        // Assert
        Assert.NotNull(prompts);
        Assert.NotEmpty(prompts);
        // Further assertions can be added here to check specific prompt values if needed
        // For example: Assert.Equal("Expected Role", prompts["Role_Default"]);
    }

    [Fact]
    public void GetDefaults_ReturnsEnglishPromptsForUnsupportedCulture()
    {
        // Arrange
        const string unsupportedCulture = "Unsupported";

        // Act
        var prompts = StaticPrompts.GetDefaults(unsupportedCulture);

        // Assert
        Assert.NotNull(prompts);
        Assert.NotEmpty(prompts);
        // Verify that it returns English prompts as default
        Assert.Equal("I'm Senior Backend Developer .NET.", prompts["Role_Default"]);
    }
}
