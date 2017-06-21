using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CineMark.models
{
    [DataContract]
    public class PaymentDetail
    {
        [DataMember]
        public int product_id { get; set; }

        [DataMember]
        public int payment_id { get; set; }

        [DataMember]
        public int quantity { get; set; }

        [DataMember]
        public decimal price { get; set; }

        [DataMember]
        public virtual Product products { get; set; }
    }
}