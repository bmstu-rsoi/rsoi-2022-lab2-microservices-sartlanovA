using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace payment.Dto
{
    public class PaymentDto
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("payment_uid")]
        public Guid payment_uid { get; set; }

        [JsonPropertyName("status")]
        public string status { get; set; }

        [JsonPropertyName("price")]
        public int price { get; set; }
    }
}
