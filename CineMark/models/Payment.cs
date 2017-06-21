using System;

using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CineMark.models
{
    [DataContract]
    public class Payment
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public int programming_id { get; set; }

        [DataMember]
        public int creator_by { get; set; }

        [DataMember]
        public int headquarter_id { get; set; }

        [DataMember]
        public string client { get; set; }

        [DataMember]
        public int quantity { get; set; }

        [DataMember]
        public programming programming { get; set; }

        [DataMember]
        public ICollection<PaymentDetail> payment_detail { get; set; }
    }
}