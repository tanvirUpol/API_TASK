using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class UserRepo
    {
        static NMSEntities db = new NMSEntities();
        public static List<User> Get()
        {
            return db.Users.ToList();
        }
        public static User Get(int id)
        {
            var department = db.Users.Find(id);
            return department;
        }
    }
}
