using Azure.AI.OpenAI;

namespace Nara.Services;

public interface INaraService
{
    public Task<ChatResponseMessage?> GetChatCompletion(string input);
}