using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Script.Serialization;

namespace CineMark.models
{
    [DataContract]
    public class Genre
    {
  
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string name { get; set; }
 
    }
}