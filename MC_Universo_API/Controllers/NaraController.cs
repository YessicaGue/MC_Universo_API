using Azure.AI.OpenAI;
using Microsoft.AspNetCore.Mvc;
using Nara.Services;

namespace MC_Universo_API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NaraController(INaraService naraService) : ControllerBase
{
    // Get Nara Chat Completion from FormData
    [HttpPost("chat")]
    public async Task<ActionResult<ChatResponseMessage>> GetChatCompletion([FromForm] string input)
    {
        var response = await naraService.GetChatCompletion(input);
        return response == null ? BadRequest() : Ok(response);
    }
}