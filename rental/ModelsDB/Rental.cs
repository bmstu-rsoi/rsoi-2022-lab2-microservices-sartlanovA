using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rentals.ModelsDB
{
    public partial class Rental
    {
        public int Id { get; set; }
        public Guid RentalUid { get; set; }
        public string Username { get; set; } = null!;
        public Guid PaymentUid { get; set; }
        public Guid CarUid { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string Status { get; set; } = null!;
    }
}