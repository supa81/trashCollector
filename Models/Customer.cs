using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Member Id")]
        public string Name { get; set; }
        [DisplayName("Name")]
        public string SuperHeroAlterEgo { get; set; }
        [DisplayName("Primary Abilities")]
        public string Primarysuperheroability { get; set; }
        [DisplayName("Secondary Abilities")]
        public string Secondarysuperheroability { get; set; }
        [DisplayName("Catch Phrase")]
        public string CatchPhrase { get; set; }
    }
}
