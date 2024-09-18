
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MoviesApi.Entidades;

namespace MoviesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GeneroController:ControllerBase
    {
        [HttpGet]
        public ActionResult<List<GeneroClass>> Get()
        {
            DatosClass datos = new DatosClass();
            List<GeneroClass> lista = datos.getListGenero();

            if (lista.Count==0)
            {
                return  NotFound();
            }
            return lista;
        }

        [HttpGet("id")]
        public ActionResult<GeneroClass> GetById(int id)
        {
            DatosClass dato=   new DatosClass();
            GeneroClass genero=  dato.getGenero(id);
            if (genero is null)
            {
                return NotFound();
            }

            return genero;
        }

        [HttpPost]
        public void Post()
        {

        }

        [HttpPut]
        public void Put()
        {

        }
        [HttpDelete]
        public void Delete()
        {

        }
    }
}
