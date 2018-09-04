using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{


   public class Book
    {
        public string b_id { get; set; }
        public string b_mname { get; set; }
        public string b_bname { get; set; }
        public string b_version { get; set; }
        public string b_author { get; set; }
        public string b_press { get; set; }
        public string b_type { get; set; }
        public DateTime b_pdate { get; set; }
        public DateTime b_indate { get; set; }
        public string b_num { get; set; }
        public string b_intro { get; set; }
     
    }
}
