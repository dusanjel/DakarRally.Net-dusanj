using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakarRally.Net_dusanj.Domain.Entity
{
    public class Race
    {
        public const decimal Distance = 10000;

        public Guid Id { get; set; }

        public DateTime Year { get; set; }

        public int RaceStatus { get; set; }

        public virtual ICollection<Vehicle> Vehicle { get; set; }
        
    }
}
