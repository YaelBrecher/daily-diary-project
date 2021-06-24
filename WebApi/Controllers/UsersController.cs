using BL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{

    public class UsersController : ApiController
    {
        UserBL userBL = new UserBL();
        // GET api/values
        [HttpGet]
        public IEnumerable<UserDTO> Get()
        {
            return userBL.GetUsersDTO();
        }

        //GET api/values/5
        //[HttpGet("{loginName}/{password}")]
        public UserDTO Get(string loginName, string password)
        {
            return userBL.GetUserDTO(loginName, password);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromUri] UserDTO user)
        {
            userBL.AddUser(user);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] UserDTO user)
        {

            userBL.PutUser(id, user);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {

        }
    }
}
