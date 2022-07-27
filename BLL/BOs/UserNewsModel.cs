using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BOs
{
    public class UserNewsModel : UserModel
    {
        public List<NewsModel> News { get; set; }  

        public UserNewsModel()
        {
            News = new List<NewsModel>();
        }

    }
}
