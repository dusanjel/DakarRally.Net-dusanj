using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DakarRally.Net_dusanj.Domain.Entity
{
    public class DakarRallyDBContext : DbContext
    {
        public DakarRallyDBContext(DbContextOptions<DakarRallyDBContext> options)
            : base(options)
        { }
    }
}
