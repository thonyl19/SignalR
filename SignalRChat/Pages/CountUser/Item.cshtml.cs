using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SignalRChat.Pages.CountUser
{
    public class Item : PageModel
    {
        private readonly ILogger<Item> _logger;

        public string id {get;set;} = null;
        public int Count {get;set;} = 0 ;

        public Item(ILogger<Item> logger)
        {
            _logger = logger;
        }

        public void OnGet(string id = null)
        {
            if (!string.IsNullOrEmpty(id)){
                if (SignalRChat.Hubs.UserCountHub._Users.ContainsKey(id))
                    this.id = id;
            }
            this.Count =  SignalRChat.Hubs.UserCountHub._Users.Count();
        }
    }
}