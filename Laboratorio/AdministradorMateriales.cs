using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio
{
    public class AdministradorMateriales
    {
        laboratorioEntities contexto;

        public AdministradorMateriales(laboratorioEntities contexto)
        {
            this.contexto = contexto;
        }

        public List<material> ObtenerTodos()
        {
            return contexto.material.ToList();
        }

        public void AgregarMaterial(material material)
        {
            var materialGuardado = contexto.material.FirstOrDefault(x => x.Nombre == material.Nombre);

            if (materialGuardado == null)
            {
                contexto.material.Add(material);
                contexto.SaveChanges();
                Actualizado?.Invoke();
            }
            else
            {
                throw new ApplicationException("Ya se agregó un material con ese nombre");
            }
        }

        public delegate void Actualizar();
        public event Actualizar Actualizado;
    }
}
