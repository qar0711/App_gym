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
    
    public partial class Estados_pers
    {
        public int Id { get; set; }
        public int Id_estado { get; set; }
        public int Id_persona { get; set; }
        public string Comentario { get; set; }
        public System.DateTime Fecha { get; set; }
    
        public virtual Personas Personas { get; set; }
        public virtual T_estados T_estados { get; set; }
    }
}
