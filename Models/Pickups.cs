using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Pickups
    {
        [Key]
        [DisplayName("Address")]
        public int Address { get; set; }
        [DisplayName("ZipCode")]
        public string Zipcode { get; set; }
        [DisplayName("Customer")]
        public string Customer { get; set; }
        [DisplayName("Employee Who Collected Trash")]
        public string EmployeeWhoPickedUp{ get; set; }
        [DisplayName("Day Trash was Collected")]
        public int Daypickedup { get; set; }
        [DisplayName("Trash Collection Time")]
        public string PickUpTime { get; set; }
    }
}
