using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio
{
    public class MaterialPedido
    {
        public int MaterialId { get; set; }
        public string NombreMaterial { get; set; }
        public int Cantidad { get; set; }
        public int EstadoMaterialId { get; set; }
    }
}
