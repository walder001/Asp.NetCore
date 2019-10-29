using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Modelo
{
    [Serializable]
    public class Persona
    {
        [Key]
        public int PersonaId { get; set; }
        public string Nombres { get; set; }
        public int Edad { get; set; }
        public virtual List<Direcciones> Direcciones {get; set;}
        
    }
}
