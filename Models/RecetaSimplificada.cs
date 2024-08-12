using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaComida.Model
{
    public class RecetaSimplificada
    {
        public string Nombre { get; set; }
        public List<string> Ingredientes { get; set; }
        public string Instrucciones { get; set; }
        public string ImagenUrl { get; set; }
    }
}
