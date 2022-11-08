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
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();


            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
        }
    }
}
