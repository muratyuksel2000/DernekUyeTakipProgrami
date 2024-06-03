using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekTakip01.Models
{
    public class Payment
    {
        public int Id { get; set; }        
        public double Paid { get; set; }
        public string Month { get; set; }
        public int MemberId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public virtual Member Member { get; set; }
    }
}
