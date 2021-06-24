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
    public class UserTaskController : ApiController
    {
        UserTaskBL UserTaskBL = new UserTaskBL();
        //GET api/value
        [HttpGet]
        public IEnumerable<UserTaskDTO> Get(int UserId)
        {

            return UserTaskBL.GetUserTaskDTO(UserId);
        }

        //GET api/values/5
        public List<UserTaskDTO> Get(int id,DateTime date)
        {
            return UserTaskBL.GetUserTaskByDateDTO(id, date);
        }

        //POST api/values
        public void Post([FromBody] UserTaskDTO task)
        {
            UserTaskBL.AddUserTaskDTO(task);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/values/5
        public void Delete(int id)
        {

        }
    }
}
