using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace payment.Database
{
    public class PaymentContext
    {
     
            protected PaymentContext()
            {
            }

            public PaymentContext(DbContextOptions options) : base(options)
            {
            }

            public DbSet<PaymentEntity> Payment { get; set; }

        
    }
}
