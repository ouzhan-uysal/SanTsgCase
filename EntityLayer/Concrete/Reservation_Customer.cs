using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Reservation_Customer
    {
        [Key]
        //public int Reservation_ID { get; set; }
        public int Customer_ID { get; set; }

        // Reservation Table ile ilişkilendirme: Reservation_ID
        public Reservation? Reservation { get; set; }
        // Customer Table ile ilişkilendirme: Customer_ID
        //public List<Customer> Customer { get; set; }

    }
}
