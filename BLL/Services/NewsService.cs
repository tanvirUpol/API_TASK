using BLL.BOs;
using DAL.EF;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class NewsService
    {
        public static List<NewsModel> Get()
        {
            var data = NewsRepo.Get();
            var rdata = new List<NewsModel>();
            foreach (var item in data)
            {
                rdata.Add(new NewsModel()
                {
                    Id = item.Id,
                    Title = item.Title,
                    Type = item.Type,
                    Date = item.Date,
                    C_id = item.C_id,
                    U_id = item.U_id,
                });
            }
            return rdata;
        }

        public static NewsModel Get(int id)
        {
            var data = NewsRepo.Get(id);
            var rdata = new NewsModel();

            rdata.Id = data.Id;
            rdata.Title = data.Title;
            rdata.Type = data.Type;
            rdata.Date = data.Date;
            rdata.C_id = data.C_id;
            rdata.U_id = data.U_id;

            return rdata;
        }

        //Delete
        public static bool Delete(int id)
        {
            var data = NewsRepo.Delete(id);
            return data;
        }

        //create
        public static bool Create(NewsModel n)
        {
            var news = new News()
            {
                Title = n.Title,
                C_id = n.C_id,
                U_id = n.U_id,
                Type = n.Type,
                Date = n.Date,
            };
            return NewsRepo.Create(news);
        }


        //create
        public static bool Update(NewsModel n)
        {
            var news = new News()
            {
                Id = n.Id,
                Title = n.Title,
                C_id = n.C_id,
                U_id = n.U_id,
                Type = n.Type,
                Date = n.Date,
            };
            return NewsRepo.Update(news);
        }
    }
}
