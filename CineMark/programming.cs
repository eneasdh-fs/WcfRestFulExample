//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CineMark
{
    using System;
    using System.Collections.Generic;
    
    public partial class programming
    {
        public programming()
        {
            this.payments = new HashSet<payments>();
        }
    
        public int id { get; set; }
        public int movie_id { get; set; }
        public int headquarter_id { get; set; }
        public string room { get; set; }
        public short limit { get; set; }
        public System.DateTime release_at { get; set; }
        public short occupied { get; set; }
    
        public virtual headquarters headquarters { get; set; }
        public virtual movies movies { get; set; }
        public virtual ICollection<payments> payments { get; set; }
    }
}
