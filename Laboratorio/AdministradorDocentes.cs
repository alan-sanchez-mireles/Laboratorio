using System;
using System.Collections.Generic;
using System.Data.Objects.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio
{
    public class AdministradorDocentes
    {
        laboratorioEntities contexto;

        public AdministradorDocentes(laboratorioEntities contexto)
        {
            this.contexto = contexto;
        }

        public docente ObtenerDocente(int clave)
        {
            return contexto.docente.FirstOrDefault(x=>x.NumeroEmpleado == clave);
        }

        public List<docente> BuscarDocente(string texto)
        {
            return contexto.docente.Where(x => (x.Nombres + " " + x.ApellidoPaterno + " " + x.ApellidoMaterno).Contains(texto)).ToList();
        }

        public List<docente> ObtenerTodos()
        {
            return contexto.docente.ToList();
        }
    }
}
