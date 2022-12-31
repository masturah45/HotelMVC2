using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Hotel_MVC2.Models.Enum;

namespace Hotel_MVC2.Models
{
    public class Room
    {
        [Key]
        [DisplayName("RoomNumber")]
        public string RoomNumber{get;set;}
        [Required]
        public RoomType Type{get;set;}
        public double Amount{get;set;}
        [DisplayName("Date Created")] 
        public DateTime DateCreated{get;set;} = DateTime.Now;
    }
}