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
    public class GetLeaveRequestHandlers : IRequestHandler<GetLeaveRequest, DepartmentDto>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public GetLeaveRequestHandlers(ILeaveRequestRepository leaveRequestRepository, IMapper imapper)
        {
            this._mapper = imapper;
            this._leaveRequestRepository = leaveRequestRepository;

        }
        public async Task<DepartmentDto> Handle(GetLeaveRequest request, CancellationToken cancellationToken)
        {
            var LeaveRequest =await _leaveRequestRepository.GetLeaveRequestWithDatails(request.Id);
            return _mapper.Map<DepartmentDto>(LeaveRequest);
        }
    }
}
