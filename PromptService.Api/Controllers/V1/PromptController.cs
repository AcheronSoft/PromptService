using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Matching;
using Microsoft.Extensions.Options;
using PromptService.Api.Enums;
using PromptService.Api.Extensions;
using PromptService.Api.Models.V1;
using PromptService.Api.Localization;

namespace PromptService.Api.Controllers.V1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/prompt")]
public class PromptController() : ControllerBase
{
    /// <summary>
    /// Generates an ideal AI prompt based on the Prompt Engineering 101-301 methodology.
    /// </summary>
    [HttpGet("generate")]
    public ActionResult<GeneratePromptResponse> GeneratePrompt(
        [FromQuery] string role,
        [FromQuery] string context,
        [FromQuery] string task,
        [FromQuery] string constraints,
        [FromQuery] string outputFormat,
        [FromQuery] string qualityCriteria,
        [FromQuery] Language commentLanguage = Language.English,
        [FromQuery] Language explainLanguage = Language.Russian)
    {
        var response = new GeneratePromptResponse
        {
            Role = role,
            Context = context,
            Task = task,
            Constraints = constraints,
            OutputFormat = outputFormat,
            QualityCriteria = qualityCriteria,
            CommentLanguage = commentLanguage,
            ExplainLanguage = explainLanguage
        };

        return Ok(response);
    }
    
    /// <summary>
    /// Generates an ideal AI prompt based on the Prompt Engineering 101-301 methodology. More convenient for external integrations than its GET counterpart.
    /// </summary>
    [HttpPost("generate")]
    public ActionResult<GeneratePromptResponse> GeneratePrompt(GeneratePromptRequest request)
    {
        var response = new GeneratePromptResponse
        {
            Role = request.Role,
            Context = request.Context,
            Task = request.Task,
            Constraints = request.Constraints,
            OutputFormat = request.OutputFormat,
            QualityCriteria = request.QualityCriteria,
            CommentLanguage = request.CommentLanguage,
            ExplainLanguage = request.ExplainLanguage
        };

        return Ok(response);
    }
}
