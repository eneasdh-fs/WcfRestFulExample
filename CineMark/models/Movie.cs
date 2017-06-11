﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Script.Serialization;

namespace CineMark.models
{
    [DataContract]
    public class Movie
    {


        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public int genre_id { get; set; }

        [DataMember]
        public string description { get; set; }

        [DataMember]
        public decimal price { get; set; }

        [DataMember]
        public string url { get; set; }

        [DataMember]
        public virtual MovieGenre genres { get; set; }
        
    }

    [DataContract]
    public class MovieGenre
    {

        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string name { get; set; }
    }
}