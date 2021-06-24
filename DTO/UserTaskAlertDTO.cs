using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserTaskAlertDTO
    {
        public int Id { get; set; }
        public Nullable<int> UserTaskId { get; set; }
        public Nullable<int> Time { get; set; }
        public Nullable<bool> SnoozeStatus { get; set; }
        public Nullable<int> SnoozeMinutes { get; set; }
    }
}
