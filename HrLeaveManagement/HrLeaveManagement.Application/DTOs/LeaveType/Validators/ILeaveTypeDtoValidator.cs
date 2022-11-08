using FluentValidation;

namespace HrLeaveManagement.Application.DTOs.LeaveType.Validators
{
    public class ILeaveTypeDtoValidator : AbstractValidator<ILeaveTypeDto>
    {
        public ILeaveTypeDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("{PropertyName} must not be empty")
                .NotNull()
                .MaximumLength(50).WithMessage("Max length should be 50");


            RuleFor(x => x.DefaultDays)
                .NotEmpty().WithMessage("{PropertyName} must not be empty")
                .GreaterThan(0).WithMessage("{PropertyName} must be greater than 0")
                .LessThan(100).WithMessage("{PropertyName} must be less than 100");

        }
    }
}
