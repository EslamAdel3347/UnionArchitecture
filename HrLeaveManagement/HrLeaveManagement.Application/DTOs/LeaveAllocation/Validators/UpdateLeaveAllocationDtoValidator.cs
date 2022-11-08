using FluentValidation;
using HrLeaveManagement.Application.Presistanse.Contracts;

namespace HrLeaveManagement.Application.DTOs.LeaveAllocation.Validators
{
    public class UpdateLeaveAllocationDtoValidator : AbstractValidator<UpdateLeaveAllocationDto>
    {
        private readonly ILeaveTypeRepository leaveTypeRepository;

        public UpdateLeaveAllocationDtoValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            this.leaveTypeRepository = leaveTypeRepository;
            Include(new ILeaveAllocationDtoValidator(leaveTypeRepository));
            RuleFor(a => a.Id).NotNull().WithMessage("{PropertyName} must be present");
        }
    }
}
