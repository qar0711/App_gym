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
    
    public partial class Caja
    {
        public int Id { get; set; }
        public System.DateTime Fecha_ini { get; set; }
        public System.DateTime Fecha_fin { get; set; }
        public int Id_factura { get; set; }
        public int Valor_dia { get; set; }
        public int Ganancia_cred { get; set; }
        public int Ganancia_efec { get; set; }
        public int Pagos { get; set; }
        public int Retiros { get; set; }
        public int Saldo_act { get; set; }
    
        public virtual Facturas Facturas { get; set; }
    }
}
