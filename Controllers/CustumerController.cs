using API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Immutable;

namespace API.Controllers
{
    [ApiController]
    [Route("Custumer")]
    public class CustumerController : ControllerBase
    {
        [HttpGet]
        [Route("findAll")]
        public dynamic Custumer()
        {

            List<Custumer> custumers = new List<Custumer>
            {
                new Custumer
                {
                    id = "1",
                    nombre = "Juan",
                    apellido = "Martinez",
                    telefono = "8298725991"
                },
                new Custumer
                {
                    id = "2",
                    nombre = "Pedro",
                    apellido = "Martinez",
                    telefono = "8298725991"
                },
                new Custumer
                {
                    id = "3",
                    nombre = "Jacobo",
                    apellido = "Martinez",
                    telefono = "8298725991"
                }
            };
            return custumers;

        }
        [HttpPost]
        [Route("update")]
        public dynamic CreateCustumer(Custumer custumer, string id)
        {
            custumer.id = id.ToString();
            return new 
            {

                succes = true,
                message = "Se agrego correctamente",
                result = custumer

            };
        }
        [HttpPost]
        [Route("create")]
        public dynamic create(Custumer custumer)
        {

            custumer.id = "4";
            return new
            {
                succes = true,
                message = "Se agrego correctamente",
                result = custumer
            };
        }

        [HttpDelete]
        [Route("delete")]
        public dynamic delete( string id, Custumer custumer) {

            return null;
        
        }
    }
}
