using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public class UserDAL
    {

        ProjectDBEntities DB = new ProjectDBEntities();
        public  List<User> GetUsersList()
        {
            return DB.Users.ToList();
        }

        public  int AddUser(User user)
        {
            try
            {
                user= DB.Users.Add(user);
                DB.SaveChanges();
                return user.Id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public  User GetUser(string loginName, string password)
        {
            using (ProjectDBEntities DB = new ProjectDBEntities())
            {
                return DB.Users.FirstOrDefault(User => User.LoginName == loginName && User.Password == password);

            }
        }
        public User PutUser(int id, User user)
        {
            User newUser = DB.Users.FirstOrDefault(User => User.Id==id);
            user.FirstPhone = user.FirstPhone;
            return newUser;
        }
        //public User GetUser()
        //{
        //    return DB.Users.Where();
        //}






    }
}
