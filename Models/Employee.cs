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
        [DisplayName("Pick Up Time")]
        public int PickUpTime { get; set; }
        [DisplayName("Start day of service")]
        public int StartDayOfService { get; set; }
        [DisplayName("End day of service")]
        public int EndDayOfService { get; set; }
        [DisplayName("Extra One Time Pick up")]
        public bool ExtraOneTimePickUp { get; set; }
        [DisplayName("Completed pick up")]
        public bool CompletedPickUp { get; set; }



        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }


    }
}
