using AutoMapper;
using HrLeaveManagement.Application.DTOs.LeaveRequest.Validators;
using HrLeaveManagement.Application.Exceptions;
using HrLeaveManagement.Application.Features.LeaveRequest.Request;
using HrLeaveManagement.Application.Presistanse.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace HrLeaveManagement.Application.Features.LeaveRequest.Handlers
{
    public class UpdateLeaveRequestHandlers : IRequestHandler<UpdateLeaveRequestCommand, Unit>
    {
        private readonly ILeaveRequestRepository leaveRequestRepository;
        private readonly IMapper mapper;
        private readonly ILeaveTypeRepository leaveTypeRepository;

        public UpdateLeaveRequestHandlers(ILeaveRequestRepository leaveRequestRepository, IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            this.leaveRequestRepository = leaveRequestRepository;
            this.mapper = mapper;
            this.leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<Unit> Handle(UpdateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var Validator = new UpdateLeaveRequestDtoValidator(leaveTypeRepository);
            var ValidationResult = await Validator.ValidateAsync(request.UpdateLeaveRequestDto);
            if (ValidationResult.IsValid == false)
                throw new ValidationExceptions(ValidationResult);


            var LeaveRequest = await leaveRequestRepository.Get(request.ID);
            if (request.UpdateLeaveRequestDto!=null)
            {
                mapper.Map(request.UpdateLeaveRequestDto, LeaveRequest);
                await leaveRequestRepository.Update(LeaveRequest);
            }
            else if (request.ChangeLeaveRequestApprovalDto!=null)
            {

                await leaveRequestRepository.ChangeLeaveRequestApproval(LeaveRequest,request.ChangeLeaveRequestApprovalDto.Approved);
            }



           
            return Unit.Value;

        }
    }
}
