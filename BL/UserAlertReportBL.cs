using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class UserAlertReportBL
    {
        //todo: לבדוק מתוך רשימת הדוחות שנרשמו למשתמש האם יש משימה שמופיעה יותר מ3 פעמים
        //ואז לבדוק על משימה זו האם הסטטוס זהה אחר/מקדים אם כן יש לשלוח הודעה

        //todo: פונקציה ששולחת מייל למשתמש האם מאשר לשנות זמן התראה

        //todo: פונקציה PUT שעורכת את המשימה ומשנה את ההתראה

        //public static void UserReport(int id)
        //{
        //    var v=UserAlertReportDAL.GetUserReportList(id).Count(c=>c.UserTask.UserId==id&&c.UserAlertReportStatus==false&&c.UserAlertReportType=="איחר");
        //    var list = UserAlertReportDAL.GetUserReportList(id).Select(x => new { TaskId = x.UserTaskId, ReportType = x.UserAlertReportType })
        //        .GroupBy(t => t.TaskId  and t.ReportType).Select(u=>u);
            
        //}
    }
}
