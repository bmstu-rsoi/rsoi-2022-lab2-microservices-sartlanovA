using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace rsoi_lr2.Database
{
    public class CarsContext : DbContext
    {
            protected CarsContext()
            {
            }

            public CarsContext(DbContextOptions options) : base(options)
            {
            }

            public DbSet<CarsEntity> Cars { get; set; }
        
    }

}
