//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Laboratorio
{
    using System;
    using System.Collections.Generic;
    
    public partial class prestamomaterial
    {
        public int Id { get; set; }
        public System.DateTime FechaEntrega { get; set; }
        public int EstadoMaterialPrestamoId { get; set; }
        public int EstadoMaterialEntregaId { get; set; }
        public int MaterialId { get; set; }
        public string Observaciones { get; set; }
        public Nullable<int> PrestamoId { get; set; }
    
        public virtual estadomaterial estadomaterial { get; set; }
        public virtual estadomaterial estadomaterial1 { get; set; }
        public virtual material material { get; set; }
        public virtual prestamo prestamo { get; set; }
    }
}
