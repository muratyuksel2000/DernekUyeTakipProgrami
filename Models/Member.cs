using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekTakip01.Models
{
    public class Member
    {
        public int Id { get; set; }
        [StringLength(11)]
        public string IdentificationNumber { get; set; }
        [StringLength(50)] 
        public string Name { get; set; }
        [StringLength(50)] 
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string DateOfBirth { get; set; }
        public string City { get; set; }
        public string BloodGroup { get; set; }
        [StringLength(50)] 
        public string Email { get; set; }        
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public virtual List<Subscription> Subscriptions { get; set; }
        public virtual List<Payment> Payments { get; set; }
    }
}
