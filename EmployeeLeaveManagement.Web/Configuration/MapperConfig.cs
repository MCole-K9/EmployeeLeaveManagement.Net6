using AutoMapper;
using EmployeeLeaveManagement.Web.Data;
using EmployeeLeaveManagement.Web.Models;
namespace EmployeeLeaveManagement.Web.Configuration
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
