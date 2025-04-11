using Microsoft.AspNetCore.SignalR;
using SignalRTest.Api.Hub;

namespace SignalRTest.Api.Endpoints
{
    public static class ChatExtensions
    {
        public static void AddEndPointsChat(this WebApplication app)
        {
            var groupBuilder = app.MapGroup("chat").WithTags("chat");

            groupBuilder.MapPost("broadcast", async (string message, IHubContext<ChatHub, IChatClient> context) =>
            {
                await context.Clients.All.ReceiveMessage($"{message} {DateTime.UtcNow}");
                return Results.NoContent();
            });
        }
    }

}
