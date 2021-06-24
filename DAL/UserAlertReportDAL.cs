using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserAlertReportDAL
    {
        static ProjectDBEntities DB = new ProjectDBEntities();

        public static List<UserAlertReport> GetUserReportList(int id)
        {
            return DB.UserAlertReports.Where(task => task.UserTask.UserId == id).ToList();
        }
    }
}
