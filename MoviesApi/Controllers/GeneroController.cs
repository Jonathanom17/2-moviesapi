

using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using MoviesApi.Entidades;

namespace MoviesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GeneroController:ControllerBase
    {
        private readonly DatosClass datos;
        private readonly IOutputCacheBufferStore oupotCache;

        public GeneroController(DatosClass _datos, IOutputCacheBufferStore oupotCache)
        {
            datos = _datos;
            this.oupotCache = oupotCache;
        }

        [HttpGet]
      
        public ActionResult<List<GeneroClass>> Get()
        {
           
            List<GeneroClass> lista = datos.getListGenero();

            if (lista.Count==0)
            {
                return  NotFound();
            }
            return lista;
        }

        [HttpGet("id")]
        [OutputCache]
        public ActionResult<GeneroClass> GetById(int id)
        {
            
            GeneroClass genero=  datos.getGenero(id);
            if (genero is null)
            {
                return NotFound();
            }

            return genero;
        }

        [HttpPost]
        public IActionResult Post([FromBody] GeneroClass genero)
        {
            
            if (datos.isExisteGenero(genero.Nombre))
            {
                return BadRequest($"Ya existe este genero{genero.Nombre}");
            }
            return Ok();
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
