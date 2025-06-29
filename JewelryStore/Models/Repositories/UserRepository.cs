using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JewelryStore.Models.Repositories
{
	public class UserRepository : IRepository<UserView>
    {
        private static UserRepository _instance = null;

        private UserRepository() { }
        public static UserRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserRepository();
                }
                return _instance;
            }
        }

        //đoạn dưới cần sửa lại

        //public bool Create(UserView entity)
        //{
        //    try
        //    {
        //        using (var db = new Ex_web_storyEntities())
        //        {
        //            db.tbl_user.Add(new tbl_user
        //            {
        //                C_username = entity.UserName,
        //                C_password = entity.PassWord,
        //                C_name = entity.Name,
        //                C_image = entity.Image,
        //                C_score = entity.Score,
        //                C_levelid = entity.LevelId,
        //                C_active = entity.Active
        //            });
        //            db.SaveChanges();
        //            return true;
        //        }
        //    }
        //    catch { return false; }
        //}

        //public bool Delete(User entity)
        //{
        //    try
        //    {
        //        using (var db = new Ex_web_storyEntities())
        //        {
        //            var obj = db.tbl_user.Find(entity.Id);
        //            if (obj != null)
        //            {
        //                db.tbl_user.Remove(obj);
        //                db.SaveChanges();
        //                return true;
        //            }
        //        }
        //    }
        //    catch { }
        //    return false;
        //}

        //public User FindById(int id)
        //{
        //    try
        //    {
        //        using (var db = new Ex_web_storyEntities())
        //        {
        //            return db.tbl_user
        //                .Where(a => a.C_id == id)
        //                .Select(a => new User
        //                {
        //                    Id = a.C_id,
        //                    UserName = a.C_username,
        //                    PassWord = a.C_password,
        //                    Name = a.C_name,
        //                    Image = a.C_image,
        //                    Score = (int)a.C_score,
        //                    LevelId = (int)a.C_levelid,
        //                    Active = (int)a.C_active
        //                }).FirstOrDefault();
        //        }
        //    }
        //    catch { return null; }
        //}

        //public HashSet<User> FindByKeywork(string keywork)
        //{
        //    try
        //    {
        //        using (var db = new Ex_web_storyEntities())
        //        {
        //            return db.tbl_user
        //                .Where(a => a.C_name.Contains(keywork))
        //                .Select(a => new User
        //                {
        //                    Id = a.C_id,
        //                    UserName = a.C_username,
        //                    PassWord = a.C_password,
        //                    Name = a.C_name,
        //                    Image = a.C_image,
        //                    Score = (int)a.C_score,
        //                    LevelId = (int)a.C_levelid,
        //                    Active = (int)a.C_active
        //                }).ToHashSet();
        //        }
        //    }
        //    catch { return new HashSet<User>(); }
        //}

        //public HashSet<User> GetAll()
        //{
        //    try
        //    {
        //        using (var db = new Ex_web_storyEntities())
        //        {
        //            return db.tbl_user
        //                .Select(a => new User
        //                {
        //                    Id = a.C_id,
        //                    UserName = a.C_username,
        //                    PassWord = a.C_password,
        //                    Name = a.C_name,
        //                    Image = a.C_image,
        //                    Score = (int)a.C_score,
        //                    LevelId = (int)a.C_levelid,
        //                    Active = (int)a.C_active
        //                }).ToHashSet();
        //        }
        //    }
        //    catch { return new HashSet<User>(); }
        //}

        //public bool Update(User entity)
        //{
        //    try
        //    {
        //        using (var db = new Ex_web_storyEntities())
        //        {
        //            var obj = db.tbl_user.Find(entity.Id);
        //            if (obj != null)
        //            {
        //                obj.C_username = entity.UserName;
        //                obj.C_password = entity.PassWord;
        //                obj.C_name = entity.Name;
        //                obj.C_image = entity.Image;
        //                obj.C_score = entity.Score;
        //                obj.C_levelid = entity.LevelId;
        //                obj.C_active = entity.Active;
        //                db.SaveChanges();
        //                return true;
        //            }
        //        }
        //    }
        //    catch { }
        //    return false;
        //}

    }
}