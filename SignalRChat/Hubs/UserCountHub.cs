using Microsoft.AspNetCore.SignalR;

namespace SignalRChat.Hubs
{
    public class UserCountHub : Hub
    {
        public static List<string> _products = new();
        public static Dictionary<string,int> _Users = new Dictionary<string,int>();
        public async Task SendProduct(string productName)
        {
            _products.Add(productName);
            await Clients.All.SendAsync("ReceiveProduct", productName, _products.Count());
        }
        public async Task ResetProduct()
        {
            _products.Clear();
            await Clients.All.SendAsync("ReceiveResetProduct");
        }

        public async Task Counts()
        {
            _products.Clear();
            await Clients.All.SendAsync("Counts",_Users.Count());
        }

        public async Task NewUser()
        {
            var user = Guid.NewGuid().ToString();
            _Users.Add(user,0);
            await Clients.All.SendAsync("NewUser",user,_Users.Count());
        }

        public async Task RemoveUser(string id)
        {
            if (_Users.ContainsKey(id)) {
                _Users.Remove(id);
                await Clients.All.SendAsync("Counts",_Users.Count());
            }
        }

        // public async Task UserList()
        // {
        //     await Clients.All.SendAsync(_User.Count());
        // }
    }
}