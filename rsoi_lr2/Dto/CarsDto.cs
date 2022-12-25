﻿using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rsoi_lr2.Dto
{
    public class CarsDto
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("car_uid")]
        public Guid car_uid { get; set; }

        [JsonPropertyName("brand")]
        public string brand { get; set; }

        [JsonPropertyName("model")]
        public string model { get; set; }

        [JsonPropertyName("registration_number")]
        public string registration_number { get; set; }

        [JsonPropertyName("power")]
        public int power { get; set; }

        [JsonPropertyName("price")]
        public int price { get; set; }

        [JsonPropertyName("type")]
        public string type { get; set; }

        [JsonPropertyName("availability")]
        public bool availability { get; set; }

    }
}
