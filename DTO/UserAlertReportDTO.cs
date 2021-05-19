using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserAlertReportDTO
    {
        public int UserAlertReportId { get; set; }
        public Nullable<int> UserTaskId { get; set; }
        public Nullable<System.DateTime> UserAlertReportDate { get; set; }
        public Nullable<bool> UserAlertReportStatus { get; set; }
        public string UserAlertReportType { get; set; }
        public Nullable<int> UserAlertReportMinutes { get; set; }
    }
}
