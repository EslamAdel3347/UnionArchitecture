using AutoMapper;
using HrLeaveManagement.Application.DTOs;
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
