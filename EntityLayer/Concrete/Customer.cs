using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        [StringLength(20)]
        public string? Name { get; set; }
        [StringLength(20)]
        public string? Surname { get; set; }
        [StringLength(12)]
        public string? Phone { get; set; }
        [StringLength(25)]
        public string? Email { get; set; }
        [StringLength(5)]
        public string? Type { get; set; }  // Adult or Child


        // link to Reservation_Customers Table: Customer_ID
        public Reservation_Customer Reservation_Customer { get; set; }
    }
}
