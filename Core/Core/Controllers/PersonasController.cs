using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DAL;
using Core.Modelo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PersonasController : ControllerBase
    {
        private readonly Contexto contexto = new Contexto(new DbContextOptions<Contexto>());

        // GET: api/Personas
        [HttpGet]

        public IEnumerable<Persona> Get()
        {
        var lista = new List<Persona>();
            lista.Add(new Persona { PersonaId = 1, Nombres = "Walder", Edad = 12, Direcciones = new List<Direcciones>() { new Direcciones { DireccionId=1,Longitud="100", Latitud="100"} } 
            });

            contexto.Persona.Add(new Persona { PersonaId = 1, Nombres = "Walder", Edad = 12, Direcciones = new List<Direcciones>() { new Direcciones { DireccionId = 1, PersonaId = 1, Longitud = "100", Latitud = "100" } } });
            contexto.SaveChanges();
            return lista;
        }
       

        // GET: api/Personas/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Personas
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
     
    }
}
