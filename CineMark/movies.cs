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
    
    public partial class movies
    {
        public movies()
        {
            this.programming = new HashSet<programming>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public int genre_id { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public string url { get; set; }
    
        public virtual genres genres { get; set; }
        public virtual ICollection<programming> programming { get; set; }
    }
}