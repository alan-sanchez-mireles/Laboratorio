
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio
{
    public class AdministradorPrestamos
    {
        laboratorioEntities contexto;

        public AdministradorPrestamos(laboratorioEntities contexto)
        {
            this.contexto = contexto;
        }

        public void Agregar(prestamo prestamo)
        {
            contexto.prestamo.Add(prestamo);
            contexto.SaveChanges();
        }

        public List<PrestamoGrid> BuscarFiltrar(string texto, int estado)
        {
            var consulta = contexto.prestamo.AsQueryable();
            if (!string.IsNullOrWhiteSpace(texto))
            {
                consulta = consulta.Where(x =>
                x.AlumnoId != null ? x.AlumnoId.Contains(texto) || (x.alumno.Nombres + " " + x.alumno.ApellidoPaterno + " " + x.alumno.ApellidoMaterno).Contains(texto) :
                (x.docente.Nombres + " " + x.docente.ApellidoPaterno + " " + x.docente.ApellidoMaterno).Contains(texto));
            }
            if (estado>0)
            {
                consulta = consulta.Where(x => x.EstadoPrestamoId == estado);
            }
            List<prestamo> resultado = consulta.OrderByDescending(x => x.Fecha).ToList();
            return resultado.Select(x => new PrestamoGrid()
            {
                Numero = x.Id,
                Estado = x.estadoprestamo.Nombre,
                Fecha = x.Fecha,
                Responsable = x.AlumnoId != null ? string.Format("{0} - {1} {2} {3}",x.alumno.NumeroControl, x.alumno.Nombres, x.alumno.ApellidoPaterno, x.alumno.ApellidoMaterno) :
                                                    string.Format("{0} - {1} {2} {3}",x.docente.NumeroEmpleado, x.docente.Nombres, x.docente.ApellidoPaterno, x.docente.ApellidoMaterno)
            }).ToList();
        }
    }
}
