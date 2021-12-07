using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Flight
    {
        [Key]
        public int ID { get; set; }
        [StringLength(20)]
        public string? Code { get; set; }
        public int Departure { get; set; }
        public int Arrival { get; set; }
        public int Capacity { get; set; }
        public int PricePerAdult { get; set; }
        public int PricePerChild { get; set; }

        public Location? Location { get; set; }

        //public Reservation_Service? Reservation_Service { get; set; }
    }
}
