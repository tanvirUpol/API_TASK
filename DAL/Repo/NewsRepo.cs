using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class NewsRepo
    {
        static NMSEntities db = new NMSEntities();
        public static List<News> Get()
        {
            return db.News.ToList();
        }

        public static News Get(int id)
        {
            var news = db.News.Find(id);
            return news;
        }

        public static bool Create(News n)
        {
            db.News.Add(n);
            var res = db.SaveChanges();
            if (res != 0)
            {
                return true;
            }
            return false;
        }

        public static bool Update(News n)
        {
            var exst = db.News.FirstOrDefault(x => x.Id == n.Id);
            if (exst != null)
            {
                db.Entry(exst).CurrentValues.SetValues(n);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool Delete(int id)
        {
            db.News.Remove(Get(id));
            db.SaveChanges();
            return true;
        }
    }
}
