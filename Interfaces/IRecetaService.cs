using LaComida.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaComida.Interfaces
{
    public interface IRecetaService
    {
        List<RecetaSimplificada> ObtenerTodasLasRecetas();
        RecetaSimplificada ObtenerRecetaPorNombre(string nombre);
    }
}
