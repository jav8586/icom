//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAOicom
{
    using System;
    using System.Collections.Generic;
    
    public partial class eventosagenda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public eventosagenda()
        {
            this.usuarios = new HashSet<usuarios>();
            this.chat_eventos = new HashSet<chat_eventos>();
        }
    
        public long idevento { get; set; }
        public Nullable<int> mes { get; set; }
        public Nullable<int> anio { get; set; }
        public string titulo { get; set; }
        public string comentario { get; set; }
        public Nullable<System.TimeSpan> horaini { get; set; }
        public Nullable<System.TimeSpan> horafin { get; set; }
        public Nullable<System.DateTime> fechainicio { get; set; }
        public Nullable<System.DateTime> fechafin { get; set; }
        public Nullable<byte> diacompleto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<usuarios> usuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chat_eventos> chat_eventos { get; set; }
    }
}
