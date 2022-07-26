using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BOs
{
    public class NewsModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public System.DateTime Date { get; set; }
        public int C_id { get; set; }
        public int U_id { get; set; }

    }
}
