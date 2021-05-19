using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Class1
    {
        DAL.Class1 c1 = new DAL.Class1();

        public List<DTO.UserDTO> UsersList = new List<DTO.UserDTO>();

        public List<DTO.UserDTO> GetUsersDTO()
        {
            foreach (var item in c1.GetUsersList())
            {
                DTO.UserDTO user = new DTO.UserDTO();
                user.UserId = item.UserId;
                user.UserLoginName = item.UserLoginName;
                user.UserFirstName = item.UserFirstName;
                user.UserLastName = item.UserLastName;
                user.UserPassword = item.UserPassword;
                user.UserFirstPhone = item.UserFirstPhone;
                user.UserSecondPhone = item.UserSecondPhone;
                user.UserEmail = item.UserEmail;
                UsersList.Add(user);
            }
            return UsersList;
        }
    }
}
