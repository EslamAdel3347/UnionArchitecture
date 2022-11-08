using AutoMapper;
using HrLeaveManagement.Application.DTOs.LeaveAllocation.Validators;
using HrLeaveManagement.Application.Exceptions;
using HrLeaveManagement.Application.Features.LeaveAllocation.Requests;
using HrLeaveManagement.Application.Presistanse.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace HrLeaveManagement.Application.Features.LeaveAllocation.Handlers.Commands
{
    public class UpdateLeaveAllocationHandler : IRequestHandler<UpdateLeaveAllocationDetailsCommand, Unit>
    {
        private readonly ILeaveAllocationRepository leaveAllocationRepository;
        private readonly IMapper mapper;
        private readonly ILeaveTypeRepository leaveTypeRepository;

        public UpdateLeaveAllocationHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            this.leaveAllocationRepository = leaveAllocationRepository;
            this.mapper = mapper;
            this.leaveTypeRepository = leaveTypeRepository;
        }
        public async Task<Unit> Handle(UpdateLeaveAllocationDetailsCommand request, CancellationToken cancellationToken)
        {

            var Validator = new UpdateLeaveAllocationDtoValidator(leaveTypeRepository);
            var ValidationResult = await Validator.ValidateAsync(request.UpdateLeaveAllocationDto);
            if (ValidationResult.IsValid == false)
                throw new ValidationExceptions(ValidationResult);


            var LeaveAllocation =await leaveAllocationRepository.Get(request.UpdateLeaveAllocationDto.Id);

            mapper.Map(request.UpdateLeaveAllocationDto, LeaveAllocation);

            await leaveAllocationRepository.Update(LeaveAllocation);

            return Unit.Value;
        }
    }
}
