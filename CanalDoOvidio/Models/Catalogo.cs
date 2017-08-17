using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CanalDoOvidio.Models
{
    public class Catalogo
    {
        public string Titulo { get; set; }
        public string Sinopse { get; set; }
        public string Diretor { get; set; }
        public float Duracao { get; set; }
        public string AnoLancamento { get; set; }
        public string Imagem { get; set; }    
    }
}