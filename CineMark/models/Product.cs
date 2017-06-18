using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CineMark.models
{
    [DataContract]
    public class Product
    {

    
        [DataMember]        
        public int id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public decimal price { get; set; }
    
    }
}