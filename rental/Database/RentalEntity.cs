using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rental.Database
{
    public class RentalEntity
    {
        public int Id { get; set; }
        public Guid rental_uid { get; set; }
        public string username { get; set; }
        public Guid payment_uid { get; set; }
        public Guid car_uid { get; set; }
        public DateTime date_from { get; set; }
        public DateTime date_to { get; set; }
        public string status { get; set; }
        
    }
}
