using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserTaskAlertDTO
    {
        public int UserTaskAlertId { get; set; }
        public Nullable<int> UserTaskId { get; set; }
        public Nullable<int> UserTaskAlertTime { get; set; }
        public Nullable<bool> UserTaskAlertSnoozeStatus { get; set; }
        public Nullable<int> UserTaskAlertSnoozeMinutes { get; set; }
    }
}
