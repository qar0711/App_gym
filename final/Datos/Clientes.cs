//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Clientes
    {
        public Clientes()
        {
            this.C_congeladas = new HashSet<C_congeladas>();
        }
    
        public int Id { get; set; }
        public int Id_persona { get; set; }
        public System.DateTime Fecha_pago { get; set; }
        public Nullable<System.DateTime> Fecha_vence { get; set; }
        public Nullable<int> Tiempo_mes { get; set; }
    
        public virtual ICollection<C_congeladas> C_congeladas { get; set; }
        public virtual Personas Personas { get; set; }
    }
}
