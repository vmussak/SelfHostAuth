using System.Collections.Generic;
using System.Web.Http;

namespace TesteAuth.Controllers
{
    [Authentication]
    public class ClienteController : ApiController
    {
        public IHttpActionResult Get()
        {
           var lstCliente = new List<Cliente>();
            for (var i = 0; i < 10; i++)
                lstCliente.Add(new Cliente(i, $"Cliente {i}"));

            return Ok(lstCliente);
        }
    }

    public class Cliente
    {
        public Cliente(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
