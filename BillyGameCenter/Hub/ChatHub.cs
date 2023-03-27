using Microsoft.AspNetCore.SignalR;

namespace BillyGameCenter.Hub;

public class ChatHub : Microsoft.AspNetCore.SignalR.Hub
{
    public System.Timers.Timer CountDownTimer { get; set; }
    
    public ChatHub()
    {
    }

    public async Task SendMsg(string user, string msg)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, msg);
    }

    public async Task StartCountDown(int sec)
    {
        await Clients.All.SendAsync("UpdateCountDown", sec);
    }
}