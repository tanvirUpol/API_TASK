using BLL.BOs;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserServices
    {
        public static List<UserModel> Get()
        {
            var data = UserRepo.Get();
            var rdata = new List<UserModel>();
            foreach (var item in data)
            {
                rdata.Add(new UserModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Email = item.Email,
                  
                });
            }
            return rdata;
        }

        public static UserModel GetOnly(int id)
        {
            var data = UserRepo.Get(id);
            var rdata = new UserModel();

            rdata.Id = data.Id;
            rdata.Name = data.Name;
            rdata.Email = data.Email;
        

            return rdata;
        }


        public static UserNewsModel Get(int id)
        {
            var user = UserRepo.Get(id);
            var u = new UserNewsModel();
            u.Id = user.Id;
            u.Name = user.Name;
            u.Email = user.Email;
            foreach(var item in user.News)
            {
                u.News.Add(new NewsModel()
                {
                    Id=item.Id,
                    C_id=item.C_id,
                    U_id=item.U_id,
                    Date = item.Date,
                    Title = item.Title, 
                    Type = item.Type,

                });
            }
            return u;

        }




    }
}
