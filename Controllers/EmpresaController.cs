using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("empresas")]
    public class EmpresaController : ControllerBase
    {


        List<Empresa> empresas = new List<Empresa> {

                new Empresa
                {
                    id = "1",
                    name = "CocaCola",
                    telefono = "8298725991",
                    location = "santo Domingo",
                },
                new Empresa
                {
                    id = "2",
                    name = "Rica",
                    telefono = "8298725991",
                    location = "santo Domingo",
                },
                new Empresa
                {
                    id = "3",
                    name = "Cola Real",
                    telefono = "8298725991",
                    location = "santo Domingo",
                }

            };

        [HttpGet]
        [Route("findAll")]
        public dynamic findAll()
        {

            return empresas;

        }
        [HttpGet, Route("find")]
        public dynamic find(string id)
        {
            if (id == id.ToString())
            {

                return new { 
                    response = true, 
                    results = empresas };

            }
            return empresas;





        }

        [HttpPost]
        [Route("create")]
        public dynamic create(Empresa empresa)
        {

            empresa.id = "4";

            return new
            {
                Response = true,
                message = "Se agrego",
                results = empresa,
            };
        }

        [HttpPut, Route("update")]
        public dynamic update(Empresa empresa, string id)
        {

            empresa.id = id.ToString();

            return new
            {
                Response = true,
                message = "Se edito",
                results = empresa,
            };

        }
    }
}
