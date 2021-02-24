using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Employee
    {
        [Key]
        [DisplayName("Employee Id")]
        public int Id { get; set; }


        [DisplayName("Name")]
        public string Name { get; set; }


        [DisplayName("Zipcode")]
        public int ZipCode { get; set; }


        [DisplayName("Weekly Pick Up Day")]
        public string WeeklyPickUpDay { get; set; }

        
        [DisplayName("Completed Pick Up")]
        public bool CompletedPickUp { get; set; }

        [DisplayName("Balance Due")]
        public decimal Balance { get; set; }













        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }


    }
}
