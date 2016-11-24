using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio
{
    public class AdministradorEstados
    {
        laboratorioEntities contexto;

        public AdministradorEstados(laboratorioEntities contexto)
        {
            this.contexto = contexto;
        }

        public List<estadoprestamo> ObtenerEstadosPrestamo()
        {
            return contexto.estadoprestamo.ToList();
        }
        public List<estadomaterial> ObtenerEstadosMaterial()
        {
            return contexto.estadomaterial.ToList();
        }
    }
}
