using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CineMark.models
{
    [DataContract]
    public class Programming
    {
        [DataMember]
        public int id { get; set; }
        
        [DataMember]
        public int movie_id { get; set; }

        [DataMember]
        public int headquarter_id { get; set; }

        [DataMember]
        public string room { get; set; }

        [DataMember]
        public short limit { get; set; }

        [DataMember]
        public System.DateTime release_at { get; set; }

        public virtual headquarters headquarters { get; set; }

        public virtual movies movies { get; set; }
        public virtual ICollection<payments> payments { get; set; }
    }
}