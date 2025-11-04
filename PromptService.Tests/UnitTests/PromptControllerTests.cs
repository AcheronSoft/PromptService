using Microsoft.AspNetCore.Mvc;
using PromptService.Api.Controllers.V1;
using PromptService.Api.Enums;
using PromptService.Api.Models.V1;

namespace PromptService.Tests.UnitTests;

public class PromptControllerTests
{
    private readonly PromptController _controller = new();

    [Fact]
    public void GeneratePrompt_Get_WithValues_ReturnsOkResultWithCorrectData()
    {
        // Arrange
        const string role = "Test Role";
        const string context = "Test Context";
        const Language commentLanguage = Language.English;
        const Language explainLanguage = Language.Russian;

        // Act
        var result = _controller.GeneratePrompt(role, context, "task", "constraints", "format", "criteria", commentLanguage, explainLanguage);

        // Assert
        var actionResult = Assert.IsType<ActionResult<GeneratePromptResponse>>(result);
        var okObjectResult = Assert.IsType<OkObjectResult>(actionResult.Result);
        var returnValue = Assert.IsType<GeneratePromptResponse>(okObjectResult.Value);
        
        Assert.Equal(role, returnValue.Role);
        Assert.Equal(context, returnValue.Context);
    }

    [Fact]
    public void GeneratePrompt_Post_WithValues_ReturnsOkResultWithCorrectData()
    {
        // Arrange
        var request = new GeneratePromptRequest
        {
            Role = "Test Role",
            Context = "Test Context",
            // ... other properties
        };

        // Act
        var result = _controller.GeneratePrompt(request);

        // Assert
        var actionResult = Assert.IsType<ActionResult<GeneratePromptResponse>>(result);
        var okObjectResult = Assert.IsType<OkObjectResult>(actionResult.Result);
        var returnValue = Assert.IsType<GeneratePromptResponse>(okObjectResult.Value);
        
        Assert.Equal(request.Role, returnValue.Role);
        Assert.Equal(request.Context, returnValue.Context);
    }
}
