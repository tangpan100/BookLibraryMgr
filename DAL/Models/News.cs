using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class News
    {
        public string n_name { get; set; }
        public string n_type { get; set; }
        public NewType n_content { get; set; }
        public DateTime n_date { get; set; }

    }
}
