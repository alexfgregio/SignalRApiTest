using Microsoft.AspNetCore.SignalR;
using SignalRTest.Api.Endpoints;
using SignalRTest.Api.Hub;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSignalR();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.AddEndPointsChat();

app.UseHttpsRedirection();

app.MapHub<ChatHub>("chat-hub");

app.Run();
