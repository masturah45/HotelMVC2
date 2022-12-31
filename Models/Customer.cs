using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Hotel_MVC2.Models.Enum;

namespace Hotel_MVC2.Models
{
    public class Customer
    {
        [Key]
        [DisplayName("CustomerNumber")]
        public string CustomerNumber {get; set;}

        [DisplayName("FirstName")]
        [Required]
        public string FirstName{get;set;}
        [DisplayName("Last Name")]
        [Required]
        public string LastName {get;set;}
        [Required]
        public string Address {get;set;}
         [Required]
        public int Age {get;set;}
        [Required]
        public GenderType Gender {get;set;}
        public string Email {get;set;}
         [DisplayName("Phone Number")]
        [Required]
        public string PhoneNumber {get;set;}
        [DisplayName("Password")]
        [Required]
        public string PassWord {get;set;}
        public DateTime DateCreated {get; set;} = DateTime.Now;
    }
}