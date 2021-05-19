using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserTaskDTO
    {
        public int UserTaskId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> TaskTypesId { get; set; }
        public string UserTaskTitle { get; set; }
        public string UserTaskComments { get; set; }
        public string UserTaskLink { get; set; }
        public string UserTaskImage { get; set; }
        public Nullable<System.DateTime> UserTaskDate { get; set; }
        public Nullable<System.TimeSpan> UserTaskStartTime { get; set; }
        public Nullable<System.TimeSpan> UserTaskEndTime { get; set; }
        public string UserTaskDays { get; set; }
    }
}
