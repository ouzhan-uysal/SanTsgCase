using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Location
    {
        [Key]
        public int Code { get; set; }
        [StringLength(20)]
        public string Name { get; set; }

        //public List<Flight> Flights { get; set; }   // 1 - N
        //public List<Hotel> Hotels { get; set; } // 1-n
    }
}
