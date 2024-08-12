using LaComida.Interfaces;
using LaComida.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaComida.Controllers
{
    public class RecetaController
    {
        private readonly IRecetaService _recetaService;

        public RecetaController(IRecetaService recetaService)
        {
            _recetaService = recetaService;
        }

        public RecetaSimplificada ObtenerReceta(string nombre)
        {
            return _recetaService.ObtenerRecetaPorNombre(nombre);
        }
    }
}
