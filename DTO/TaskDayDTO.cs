using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaskDayDTO
    {
        public int Id { get; set; }
        public Nullable<int> Value { get; set; }
        public Nullable<int> UserTaskId { get; set; }
    }
}
