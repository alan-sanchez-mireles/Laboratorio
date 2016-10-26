using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio
{
    public class AdministradorCategorias
    {
        laboratorioEntities contexto;

        public AdministradorCategorias(laboratorioEntities contexto)
        {
            this.contexto = contexto;
        }

        public List<categoria> ObtenerTodas()
        {
            return contexto.categoria.ToList();
        }


    }
}
