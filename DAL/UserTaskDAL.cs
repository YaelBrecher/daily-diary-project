using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace DAL
{
    public class UserTaskDAL
    {
        static ProjectDBEntities DB = new ProjectDBEntities();

        public static List<UserTask> GetUserTaskList(int id)
        {
            return DB.UserTasks.Where(task => task.UserId == id).ToList();
        }

        public static List<UserTask> GetUserTasByDatekList(int userId, DateTime date)
        {
            DB.UserTaskByDayOfWeek(20, 5);
            return DB.UserTasks.Where(task => task.UserId == userId && task.Date == date).ToList();
        }

        //public static void TasksByDay(DateTime date,int id)
        //{

        //    //var tasks = DB.UserTasks.Where(task => task.UserId == id).ToList();
        //    //HashSet<int> set = new HashSet<int>();
        //    //set = tasks.Select(x => x.UserTaskId);
        //    var days = DB.TaskDays.Where(day => day.TaskDaysValue == (int)date.DayOfWeek).ToList();
        //    foreach (var item in days)
        //    {
        //        if (GetUserTaskList(id).Contains(item.UserTaskId))
        //        {

        //        }
        //    }
        //    var t = GetUserTaskList(id).Where(x=>));
        //    //var myTasks = days.ForEach(L => tasks.Contains(L.UserTaskId)).ToList();

        //    //foreach (var item in days)
        //    //{
        //    //    if (tasks..Contains(item.UserTaskId))
        //    //    {
        //    //    }
        //    //}
        //}      

        public static void AddUserTask(UserTask userTask)
        {
            try
            {
                TaskCollisionTester(userTask);
                DB.UserTasks.Add(userTask);
                string s = userTask.Days;
                for (int i = 0; i < s.Length; i++)
                {
                    TaskDay taskDay = new TaskDay { UserTaskId = userTask.Id, Value = (int)s[i] };
                    DB.TaskDays.Add(taskDay);
                }
                DB.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }


        }

        public static bool TaskCollisionTester(UserTask userTask)
        {
            if (userTask.TaskTypesId == 1)
            {
               
            }
            else
            {
             return   GetUserTasByDatekList((int)userTask.UserId, (DateTime)userTask.Date).Any(item => !(item.StartTime >= userTask.EndTime || item.EndTime <= userTask.StartTime));
               
                
            }
            return true;
        }

    }
}
