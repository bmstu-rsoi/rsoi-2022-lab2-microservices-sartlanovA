using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ModelsDTO.Cars
{

    public class PaginationCarResponse
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("items")]
        public CarResponse[] Items { get; set; }
    }
}
