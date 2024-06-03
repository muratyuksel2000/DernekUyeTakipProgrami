using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekTakip01.Models
{
    public class Subscription
    {
        public int Id { get; set; }       
        [StringLength(20)]
        public string Year { get; set; }
        public double Amount { get; set; }         
        public int MemberId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public virtual Member Member { get; set; }
    }
}
