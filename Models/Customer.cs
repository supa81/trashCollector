using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
       
        
       

        [Key]
        [DisplayName("Member Id")]
        public int Id { get; set; }
        [DisplayName("Address")]
        public string Address { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("ZipCode")]
        public string ZipCode { get; set; }
        [DisplayName("Weekly Trash collection Day")]
        public DateTime WeeklyPickUpDay { get; set; }
        [DisplayName("Trash collection Pick Up ")]
        
        public DateTime StartDayOfService { get; set; }
        [DisplayName("End day of service")]
        public DateTime EndDayOfService { get; set; }
        [DisplayName("Extra One Time Trash Collection")]
        public DateTime ExtraOneTimePickUp { get; set; }

        

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
      
    }
}
