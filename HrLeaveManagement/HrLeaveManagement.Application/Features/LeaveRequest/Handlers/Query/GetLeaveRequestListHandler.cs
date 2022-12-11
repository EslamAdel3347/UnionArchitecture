using AutoMapper;
using HrLeaveManagement.Application.DTOs.LeaveRequest;
using HrLeaveManagement.Application.Features.LeaveRequest.Request;
using HrLeaveManagement.Application.Presistanse.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HrLeaveManagement.Application.Features.LeaveRequest.Handlers
{
    public class GetLeaveRequestListHandler : IRequestHandler<GetLeaveRequestList, List<LeaveRequestDto>>
    {
        private readonly ILeaveRequestRepository leaveRequestRepository;
        private readonly IMapper mapper;

        public GetLeaveRequestListHandler(ILeaveRequestRepository leaveRequestRepository,IMapper mapper)
        {
            this.leaveRequestRepository = leaveRequestRepository;
            this.mapper = mapper;
        }
        public async Task<List<LeaveRequestDto>> Handle(GetLeaveRequestList request, CancellationToken cancellationToken)
        {
            var LeaveRequestList =await leaveRequestRepository.GetLeaveRequestListWithDatai();
            return mapper.Map<List<LeaveRequestDto>>(LeaveRequestList);
        }
    }
}
