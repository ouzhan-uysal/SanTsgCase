using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Reservation
    {
        [Key]
        public int ID { get; set; }
        public int Price { get; set; }
        public bool Status { get; set; }
        public DateTime Created_at { get; set; }
        public int Created_by { get; set; }
        public DateTime Begin_date { get; set; }
        public DateTime End_date { get; set; }

        // From Users Table
        public int UserID { get; set; }
        public User? User { get; set; }
        // Reservation_Customer Table
        public List<Reservation_Customer>? Reservation_Customers { get; set; }

        // Give Reservation_Service Table: Reservation_ID
        public List<Reservation_Service>? Reservation_Services { get; set; }
    }
}
