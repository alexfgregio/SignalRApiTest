namespace SignalRTest.Api.Hub
{
    public interface IChatClient
    {
        Task ReceiveMessage(string message);
    }
}
