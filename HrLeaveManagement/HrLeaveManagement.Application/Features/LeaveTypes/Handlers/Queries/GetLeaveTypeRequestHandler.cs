using AutoMapper;
using HrLeaveManagement.Application.DTOs;
using HrLeaveManagement.Application.Features.LeaveTypes.Requests;
using HrLeaveManagement.Application.Presistanse.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace HrLeaveManagement.Application.Features.LeaveTypes.Handlers.Queries
{
    public class GetLeaveTypeRequestHandler : IRequestHandler<GetLeaveTypeRequest, LeaveTypeDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public GetLeaveTypeRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            this._leaveTypeRepository = leaveTypeRepository;
            this._mapper = mapper;
        }

        public async Task <LeaveTypeDto> Handle(GetLeaveTypeRequest request, CancellationToken cancellationToken)
        {
            var Leavetypes = await _leaveTypeRepository.Get(request.Id);
            return _mapper.Map<LeaveTypeDto>(Leavetypes);
        }
    }

}
