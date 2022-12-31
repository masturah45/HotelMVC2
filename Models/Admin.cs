using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Hotel_MVC2.Models.Enum;

namespace Hotel_MVC2.Models
{
    public class Admin
    {
        [DisplayName("FirstName")]
        [Required]
        public string FirstName{get;set;}
        [DisplayName("LastName")]
        [Required]
        public string LastName{get;set;}
        [Required]
        public string Address{get;set;}
        [Key]
        public string AdminId{get;set;}
        public int Age{get;set;}
        [Required]
        public GenderType Gender{get;set;}
        public string Email{get;set;}
        [DisplayName("PhoneNumber")]
        [Required]
        public string PhoneNumber{get;set;}
        [DisplayName("Password")]
        [Required]
        public string Password{get;set;}
        public DateTime DateCreated{get;set;} = DateTime.Now;
    }
}