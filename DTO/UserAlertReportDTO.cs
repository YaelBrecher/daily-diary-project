using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserAlertReportDTO
    {
        public int Id { get; set; }
        public Nullable<int> UserTaskId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<bool> Status { get; set; }
        public string Type { get; set; }
        public Nullable<int> Minutes { get; set; }
    }
}
