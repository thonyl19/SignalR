using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SignalRChat.Pages.SSE_Test
{
    public class Item : PageModel
    {
        private readonly ILogger<Item> _logger;

        public Item(ILogger<Item> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}