//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    
    public partial class UserTaskByDayOfWeek1_Result
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
        public int Id1 { get; set; }
        public Nullable<int> Value { get; set; }
        public Nullable<int> UserTaskId { get; set; }
    }
}