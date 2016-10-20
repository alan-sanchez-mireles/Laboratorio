using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio
{
    public class AdministradorCarreras
    {
        laboratorioEntities contexto;

        public AdministradorCarreras(laboratorioEntities contexto)
        {
            this.contexto = contexto;
        }

        public List<carrera> ObtenerTodas()
        {
            return contexto.carrera.ToList();
        }
    }
}
