using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SignalRChat.Controllers
{
    //Ref [https://blog.csdn.net/oopxiajun2011/article/details/122498269]
    [ApiController]
    [Route("api/[controller]")]
    public class SSE_TestController : ControllerBase
    {
        [HttpGet]
        public async Task<Object> T01(){
            HttpContext.Response.ContentType = "text/event-stream";
            for(int i = 0; i < 10 ;i++){
                string data = $"id:{Guid.NewGuid().ToString()}";
                var bitys = Encoding.UTF8.GetBytes(data);
                await HttpContext.Response.Body.WriteAsync(bitys);
                await HttpContext.Response.Body.FlushAsync();
                System.Threading.Thread.Sleep(2000);
            }
            return null;
        }
    }
}