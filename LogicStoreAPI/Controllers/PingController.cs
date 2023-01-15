using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LogicStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ping : Controller
    {
        [HttpGet]
        public ActionResult GetPing()
        {
            var res = new ContentResult();
            res.Content = "Pong";
            res.ContentType = "text/plain";

            return res;

        }
    }
}
