using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaskDayDTO
    {
        public int TaskDaysId { get; set; }
        public string TaskDaysValue { get; set; }
        public Nullable<int> UserTaskId { get; set; }
    }
}
