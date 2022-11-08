using FluentValidation;

namespace HrLeaveManagement.Application.DTOs.LeaveType.Validators
{
    public class UpdateLeaveTypeValidator : AbstractValidator<LeaveTypeDto>
    {
        public UpdateLeaveTypeValidator()
        {
            Include(new ILeaveTypeDtoValidator());

            RuleFor(a => a.Id).NotNull().WithMessage("{PropertyName} must be Not Empty"); 

        }

        
    }
}
