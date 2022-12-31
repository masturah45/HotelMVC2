using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Hotel_MVC2.Models.Enum;

namespace Hotel_MVC2.Models
{
    public class Booking
    {
        [Key]
        [DisplayName("BookingNumber")]
        public string BookingNumber{get;set;}
        [DisplayName("Booking Date")]
        public DateTime BookingDate{get;set;}
        [Required]
        [DisplayName("Check In Date")]
        public DateTime CheckInDate{get;set;}
        [Required]
        [DisplayName("Check Out Date")]
        public DateTime CheckOutDate{get;set;}
        [Required]
        public RoomType Type{get;set;}
        public bool isAvailable{get;set;}
        public bool isChecked{get;set;}
        public DateTime DateCreated{get;set;} = DateTime.Now;
    }
}