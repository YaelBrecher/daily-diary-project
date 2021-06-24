using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBRetrieval
    {
        ProjectDBEntities DB = new ProjectDBEntities();

        public List<User> GetUsersList()
        {
            return DB.Users.ToList();
        }

        public List<TaskDay> GetTaskDaysList()
        {
            return DB.TaskDays.ToList();
        }

        public List<TaskType> GetTaskTypesList()
        {
            return DB.TaskTypes.ToList();
        }

        public List<UserAlertReport> GetUserAlertReportsList()
        {
            return DB.UserAlertReports.ToList();
        }

        public List<UserTask> GetUserTasksList()
        {
            return DB.UserTasks.ToList();
        }

        public List<UserTaskAlert> GetUserTaskAlertsList()
        {
            return DB.UserTaskAlerts.ToList();
        }

    }
}
