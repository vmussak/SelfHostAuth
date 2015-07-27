using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace TesteAuth
{
    public static class Validation
    {
        public static bool IsAuthenticated(string token)
        {
            var redis = ConnectionMultiplexer.Connect("127.0.0.1:6379");
            var db = redis.GetDatabase();

            string value = db.StringGet(token);
           
            return !string.IsNullOrEmpty(value);
        }
    }
}
