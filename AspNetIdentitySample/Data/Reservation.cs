using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetIdentitySample.Data
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public short NumOfGuests { get; set; }
        public string Instructions { get; set; }
    }
}
