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
        DateTime date = new DateTime(2002, 10, 22);
       

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
        public string WeeklyPickUpDay { get; set; }
        [DisplayName("Trash collection Pick Up ex. 2/22/2021 ")]
        public int PickUpTime { get; set; }
        [DisplayName("Start day of service")]
        public string StartDayOfService { get; set; }
        [DisplayName("End day of service")]
        public string EndDayOfService { get; set; }
        [DisplayName("Extra One Time Trash Collection")]
        public bool ExtraOneTimePickUp { get; set; }
        public int Date { get; set; }




        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
      
    }
}
