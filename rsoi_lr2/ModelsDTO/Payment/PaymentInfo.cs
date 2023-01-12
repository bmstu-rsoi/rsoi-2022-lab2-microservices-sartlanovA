using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ModelsDTO.Payments
{

    public class PaymentInfo
    {
        [JsonProperty("paymentUid")]
        public Guid PaymentUid { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }
    }
}