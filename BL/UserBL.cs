using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class UserBL
    {
        UserDAL userDAL = new UserDAL();
        public UserDTO GetUserDTO(string loginName, string password)
        {
            UserDTO user = MapperGlobel.mapper.Map<UserDTO>(userDAL.GetUser(loginName, password));
            if (user != null)
            {
                return user;
            }
            throw new Exception("user not exist");
        }

        public List<UserDTO> GetUsersDTO()
        {
            return MapperGlobel.mapper.Map<List<UserDTO>>(userDAL.GetUsersList());
        }

        public void AddUser(UserDTO user)
        {
            userDAL.AddUser(MapperGlobel.mapper.Map<User>(user));
        }

        public void PutUser(int userId, UserDTO user)
        {
            userDAL.PutUser(userId, MapperGlobel.mapper.Map<User>(user));
        }

    }
}
