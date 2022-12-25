using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace payment.Database
{
    public class PaymentEntity
    {

        public int Id { get; set; }
        public double price { get; set; }
        public Guid payment_uid { get; set; }
        public string status { get; set; }
    }
}
