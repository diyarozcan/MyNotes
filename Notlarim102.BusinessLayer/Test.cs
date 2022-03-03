using Notlarim102.DataAccessLayer;
using Notlarim102.DataAccessLayer.EntityFramework;
using Notlarim102.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notlarim102.BusinessLayer
{
    public class Test
    {
        Repository<NotlarimUser> ruser = new Repository<NotlarimUser>();
        Repository<Category> rcat = new Repository<Category>();
        Repository<Note> rnote = new Repository<Note>();
        Repository<Comment> rcom = new Repository<Comment>();
        Repository<Liked> rlike = new Repository<Liked>();

        public Test()
        {
            //NotlarimContext db = new NotlarimContext();
            //db.Categories.ToList();
            //db.Database.CreateIfNotExists();

            var test = rcat.List();
            var test1 = rcat.List(x=> x.Id>5);
        }

        public void InsertTest()
        {
            int result = ruser.Insert(new NotlarimUser()
            {
                Name="Hakan",
                Surname="Yavas",
                Email="yavasyavas@gmail.com",
                ActivateGuid=Guid.NewGuid(),
                IsActive=true,
                IsAdmin=false,
                Username="lavas",
                Password="333",
                CreatedOn=DateTime.Now,
                ModifiedOn=DateTime.Now,
                ModifiedUsername="lavas"
            });
        }

        public void UpdateTest()
        {
            NotlarimUser user = ruser.Find(x => x.Username == "lavas");
            if (user!=null)
            {
                user.Password = "111111";
                ruser.Update(user);
            }
        }
        public void DeleteTest()
        {
            NotlarimUser user = ruser.Find(x => x.Username == "lavas");
            if (user!=null)
            {
                ruser.Delete(user);
            }
        }
        public void CommenTest()
        {
            NotlarimUser user = ruser.Find(s => s.Id == 1);
            Note note = rnote.Find(s => s.Id == 3);

            Comment comment = new Comment()
            {
                Text = "Bu bir test datasidir",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                ModifiedUsername = "diyarozcan",
                Note =note,
                Owner =user,
            };
            rcom.Insert(comment);
        }
    }
}
