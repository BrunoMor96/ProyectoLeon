//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiciosBancoPeru
{
    using System;
    using System.Collections.Generic;
    
    public partial class PAGO
    {
        public int IdPago { get; set; }
        public int NroCuota { get; set; }
        public int ImportePago { get; set; }
        public System.DateTime FechaPago { get; set; }
        public System.DateTime FechaVencimiento { get; set; }
        public string EstadoPago { get; set; }
        public int IdPrestamo { get; set; }
    
        public virtual PRESTAMO PRESTAMO { get; set; }
        public virtual PRESTAMO PRESTAMO1 { get; set; }
        public virtual PRESTAMO PRESTAMO2 { get; set; }
    }
}
