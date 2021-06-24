using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserTaskDTO
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> TaskTypesId { get; set; }
        public string Title { get; set; }
        public string Comments { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public Nullable<System.TimeSpan> EndTime { get; set; }
        public string Days { get; set; }
    }
}
