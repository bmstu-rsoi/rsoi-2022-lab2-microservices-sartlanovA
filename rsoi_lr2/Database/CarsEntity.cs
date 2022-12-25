using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rsoi_lr2.Database
{
    public class CarsEntity
    {
        public int Id { get; set; }
        public Guid car_uid { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string registration_number { get; set; }
        public int power { get; set; }
        public int price { get; set; }
        public string type { get; set; }
        public bool availability { get; set; }

    }
}
