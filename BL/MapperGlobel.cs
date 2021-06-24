using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BL
{
    public class MapperGlobel
    {
        public static IMapper mapper;
        static MapperGlobel()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserDTO, User>();
                cfg.CreateMap<User, UserDTO>();
                cfg.CreateMap<UserTask, UserTaskDTO>();
                cfg.CreateMap<UserTaskDTO, UserTask>();//.AfterMap(x,d=>x.UserName==d.);
                cfg.CreateMap<UserTaskAlert, UserTaskAlertDTO>();
                cfg.CreateMap<UserTaskAlertDTO, UserTaskAlert>();
                cfg.CreateMap<TaskDay, TaskDayDTO>();
                cfg.CreateMap<TaskDayDTO, TaskDay>();
                cfg.CreateMap<TaskTypeDTO, TaskType>();
                cfg.CreateMap<TaskType, TaskTypeDTO>();
                cfg.CreateMap<UserAlertReportDTO, UserAlertReport>();
                cfg.CreateMap<UserAlertReport, UserAlertReportDTO>();
            });
            mapper = config.CreateMapper();
        }
    }
}