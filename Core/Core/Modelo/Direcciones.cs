using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Modelo
{
    [Serializable]
    public class Direcciones
    {
        [Key]
        public int DireccionId { get; set; }
        public int PersonaId { get; set; }
        public string Longitud { get; set; }
        public string Latitud { get; set; }

    }
}
