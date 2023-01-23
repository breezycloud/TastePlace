using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace TastePlace.Shared.Hubs;

[Authorize]
public class AppHub : Hub
{
    public async Task Download() =>
        await Clients.All.SendAsync("Download");

}
