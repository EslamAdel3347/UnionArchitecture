using AutoMapper;
using HrLeaveManagement.Application.DTOs;
using HrLeaveManagement.Application.DTOs.Department;
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

            #region Department Mappings
            CreateMap<Department, DepartmentRequestDto>().ReverseMap();
            CreateMap<Department, DepartmentRequestListDto>().ReverseMap();
            CreateMap<Department, CreateDepartmentRequestDto>().ReverseMap();
            CreateMap<Department, UpdateDepartmentRequestDto>().ReverseMap();

            #endregion

            #region LeaveRequest Mappings
            CreateMap<LeaveRequest, DepartmentDto>().ReverseMap();
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
