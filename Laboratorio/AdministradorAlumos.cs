using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio
{
    public class AdministradorAlumos
    {
        laboratorioEntities contexto;

        public AdministradorAlumos(laboratorioEntities contexto)
        {
            this.contexto = contexto;
        }

        public List<alumno> ObtenerTodos()
        {
            return contexto.alumno.ToList();   
        }

        public void AgregarAlumno(alumno alumno)
        {
            alumno alumnoGuardado = contexto.alumno
                          .FirstOrDefault(x => x.NumeroControl == alumno.NumeroControl);

            if (alumnoGuardado == null)
            {
                contexto.alumno.Add(alumno);
                contexto.SaveChanges();
                Actualizado?.Invoke();
            }
           
        }

        public delegate void Actualizar();
        public event Actualizar Actualizado;
    }
}
