using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SignalRChat.Pages.CountUser
{
    public class Count : PageModel
    {
        private readonly ILogger<Count> _logger;

        public Count(ILogger<Count> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}