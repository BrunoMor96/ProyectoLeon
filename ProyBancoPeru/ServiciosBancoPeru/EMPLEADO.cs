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
    
    public partial class EMPLEADO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPLEADO()
        {
            this.DETALLE_PRESTAMO = new HashSet<DETALLE_PRESTAMO>();
            this.DETALLE_PRESTAMO1 = new HashSet<DETALLE_PRESTAMO>();
            this.DETALLE_PRESTAMO2 = new HashSet<DETALLE_PRESTAMO>();
        }
    
        public int IdEmpleado { get; set; }
        public string DNIEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidoEmplado { get; set; }
        public string TelefonoEmpleado { get; set; }
        public string EmailEmpleado { get; set; }
        public string DireccionEmpleado { get; set; }
        public int SueldoEmpleado { get; set; }
        public System.DateTime FechaIngreso { get; set; }
        public Nullable<System.DateTime> FechaSalida { get; set; }
        public int IdDepartamento { get; set; }
    
        public virtual DEPARTAMENTO DEPARTAMENTO { get; set; }
        public virtual DEPARTAMENTO DEPARTAMENTO1 { get; set; }
        public virtual DEPARTAMENTO DEPARTAMENTO2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_PRESTAMO> DETALLE_PRESTAMO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_PRESTAMO> DETALLE_PRESTAMO1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_PRESTAMO> DETALLE_PRESTAMO2 { get; set; }
    }
}
