using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
namespace SignalRChat.Pages.SSE_Test
{
    public class Main : PageModel
    {
        private readonly ILogger<Main> _logger;

        public Main(ILogger<Main> logger)
        {
            _logger = logger;
            
        }

        public void OnGet()
        {
            // if (Request["m"] == "broadcast") 
            //     SseProcessor.Broadcast(Request["t"] ?? "nothing");
            // else {
            //     var sseKey = Request["k"] ?? Guid.NewGuid().ToString().Substring(0, 4);
            //     var proc = new SseProcessor(sseKey, Response);
            //     proc.Run();
            // }
        }
    }
}