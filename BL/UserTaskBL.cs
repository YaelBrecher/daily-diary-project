using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class UserTaskBL
    {
        UserTaskDAL userTaskDAL = new UserTaskDAL();
        public  List<UserTaskDTO> UserTaskList = new List<UserTaskDTO>();

        public  List<UserTaskDTO> GetUserTaskByDateDTO(int id, DateTime date)
        {
            return MapperGlobel.mapper.Map<List<UserTaskDTO>>(UserTaskDAL.GetUserTasByDatekList(id,date));

        }

        public  List<UserTaskDTO> GetUserTaskDTO(int id)
        {
            return MapperGlobel.mapper.Map<List<UserTaskDTO>>(UserTaskDAL.GetUserTaskList(id));
        }

        public  void AddUserTaskDTO(UserTaskDTO task)
        {
            UserTask userTask = new UserTask();
          string nab=  userTask.User.FirstName;
            UserTaskDAL.AddUserTask(MapperGlobel.mapper.Map<UserTask>(task));
        }
    }
}
