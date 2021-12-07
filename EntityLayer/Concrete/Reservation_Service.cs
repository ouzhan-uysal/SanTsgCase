using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Reservation_Service
    {
        [Key]
        public int Service_ID { get; set; }
        // From Reservation: Reservation_ID
        public Reservation? Reservation { get; set; }

    }
}
