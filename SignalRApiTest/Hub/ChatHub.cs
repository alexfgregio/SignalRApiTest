﻿using Microsoft.AspNetCore.SignalR;

namespace SignalRTest.Api.Hub
{
    public sealed class ChatHub : Hub<IChatClient>
    {
        public override async Task OnConnectedAsync()
        {
            await Clients.All.ReceiveMessage($"{Context.ConnectionId} has joined");
        }

        public async Task SendMessage(string message)
        {
            await Clients.All.ReceiveMessage($"{Context.ConnectionId}: {message}");
        }
    }
}
