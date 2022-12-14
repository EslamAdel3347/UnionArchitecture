using AutoMapper;
using HrLeaveManagement.Application.DTOs;
using HrLeaveManagement.Application.DTOs.Department;
using HrLeaveManagement.Application.DTOs.Employee;
using HrLeaveManagement.Application.DTOs.LeaveRequest;
using HrLeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrLeaveManagement.Application.Profiles
{
  public  class MappingProfile:Profile
    {
        public MappingProfile()
        {
            //AllowNullDestinationValues = true;
           ValidateInlineMaps = false;

            #region Department Mappings
            CreateMap<Department, DepartmentRequestDto>().ForMember(dest => dest.Employees, act => act.MapFrom(src => src.Employees)).ReverseMap();
            CreateMap<Department, DepartmentRequestListDto>().ReverseMap();
            CreateMap<Department, CreateDepartmentRequestDto>().ReverseMap();
            CreateMap<Department, UpdateDepartmentRequestDto>().ReverseMap();

            #endregion


            #region employee Mappings
            CreateMap<Employee, EmployeeRequestDto>().ForMember(dest => dest.DepartmentDto, act => act.MapFrom(src => src.Department)).ReverseMap();

            CreateMap<Employee, EmployeeListRequestDto>().ReverseMap();

            CreateMap<Employee, EmployeeAndParentDto>().ForMember(dest => dest.DepName, act => act.MapFrom(src => src.Department.DepName));

            #endregion

            #region LeaveRequest Mappings
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
            CreateMap<LeaveRequest, CreateLeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, UpdateLeaveRequestDto>().ReverseMap();
            #endregion LeaveRequest

            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveAllocation, CreateLeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveAllocation, UpdateLeaveAllocationDto>().ReverseMap();

            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
            CreateMap<LeaveType, CreateLeaveTypeDto>().ReverseMap();
        }
    }
}
