using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DAL;
using Core.Modelo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
        private readonly Contexto contexto = new Contexto(new DbContextOptions<Contexto>());

        [HttpGet]
        public IEnumerable<Persona> Get()
        {
            var lista = new List<Persona>();
            lista.Add(new Persona
            {
                PersonaId = 1,
                Nombres = "Walder",
                Edad = 12,
                Direcciones = new List<Direcciones>() { new Direcciones { DireccionId = 1, PersonaId=1, Longitud = "100", Latitud = "100" } }
            });

            contexto.Persona.Add(new Persona { PersonaId = 0, Nombres = "Walder", Edad = 12,
                Direcciones = new List<Direcciones>() { new Direcciones { DireccionId = 0, Longitud = "100", Latitud = "100" } }
            });
            contexto.SaveChanges();
            return lista;
        }
    }
}
