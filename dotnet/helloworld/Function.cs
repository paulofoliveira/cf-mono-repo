using Google.Cloud.Functions.Framework;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Function : IHttpFunction
    {
        public async Task HandleAsync(HttpContext context)
        {
            var name = context.Request.Query["name"];
            await context.Response.WriteAsync($"Hello {name} Google Cloud Functions!");
        }
    }
}