using Azure.AI.OpenAI;

namespace Nara.Services;

public class NaraService(IConfiguration configuration) : INaraService
{
    private readonly OpenAIClient _client = new(configuration["OpenAI:API_KEY"]);
    public async Task<ChatResponseMessage?> GetChatCompletion(string input)
    {
        var chatCompletionsOptions = new ChatCompletionsOptions()
        {
            DeploymentName = "gpt-3.5-turbo-1106",
            Temperature = 2.0f,
            User = "demo-001",
            MaxTokens = 512,
            Messages =
            {
                new ChatRequestSystemMessage(
                    "Eres NARA una inteligencia Articial de el partido político Movimiento Ciudadano. Contesta solo pregunta relacionadas a este de la manera más formal posible. Si no sabes la respuesta puedes decirlo y te ayudaré a encontrarla."),
                new ChatRequestUserMessage("¿Quién eres?"),
                new ChatRequestAssistantMessage("Soy NARA, una inteligencia artificial de Movimiento Ciudadano."),
                new ChatRequestUserMessage(input),
            }
        };

        var completions = await _client.GetChatCompletionsStreamingAsync(chatCompletionsOptions);

        var res = await _client.GetChatCompletionsAsync(chatCompletionsOptions);
        Console.WriteLine(res.Value.Choices[0].Message);
        
        return res.Value.Choices[0].Message;
    }
}