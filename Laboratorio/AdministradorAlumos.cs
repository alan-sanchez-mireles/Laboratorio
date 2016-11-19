using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio
{
    public class AdministradorAlumnos
    {
        laboratorioEntities contexto;

        public AdministradorAlumnos(laboratorioEntities contexto)
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

        public alumno ObtenerAlumno(string numeroControl)
        {
            return contexto.alumno.FirstOrDefault(x => x.NumeroControl == numeroControl);
        }

        public List<alumno> BuscarAlumnos(string texto)
        {
            return contexto.alumno.Where(x => x.NumeroControl.Contains(texto) ||
                                         (x.Nombres + " " + x.ApellidoPaterno +
                                         " " + x.ApellidoMaterno).Contains(texto)
                                         || x.carrera.NombreCorto.Contains(texto)).ToList();
        }

        public delegate void Actualizar();
        public event Actualizar Actualizado;
    }
}
