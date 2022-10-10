using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SignalRChat.Pages
{
    public class CountUsers : PageModel
    {
        private readonly ILogger<CountUsers> _logger;

        public CountUsers(ILogger<CountUsers> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}