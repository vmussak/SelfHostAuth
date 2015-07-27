using System;
using System.Web.Http;
using StackExchange.Redis;

namespace TesteAuth.Controllers
{
    public class UserController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Authenticate(User user)
        {
            //Faz o login, ve se o cara existe e pá
            var userToken = Guid.NewGuid().ToString();
            var redis = ConnectionMultiplexer.Connect("127.0.0.1:6379");
            var db = redis.GetDatabase();
            db.StringSet(userToken, DateTime.Now.ToString());
            return Ok(userToken);
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}