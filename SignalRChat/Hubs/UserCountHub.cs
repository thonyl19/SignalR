using Microsoft.AspNetCore.SignalR;

namespace SignalRChat.Hubs
{
    public class UserCountHub : Hub
    {
        public static List<string> lstConnectionID = new List<string>();
        public override Task OnConnectedAsync()
        {
            lstConnectionID.Add(Context.ConnectionId);
            broadCastOnlineCount(lstConnectionID.Count);
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            lstConnectionID.Remove(Context.ConnectionId);
            broadCastOnlineCount(lstConnectionID.Count);
            return base.OnDisconnectedAsync(exception);
        }

        //卡在 這一段 不work
        public void broadCastOnlineCount(int count)
        {
            //Clients.All.broadCastOnlineCount(count);
        }
    }
}