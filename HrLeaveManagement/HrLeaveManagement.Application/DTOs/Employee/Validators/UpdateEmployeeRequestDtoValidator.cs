using FluentValidation;

namespace HrLeaveManagement.Application.DTOs.Employee.Validators
{
    public class UpdateEmployeeRequestDtoValidator : AbstractValidator<EmployeeRequestDto>
    {
        public UpdateEmployeeRequestDtoValidator()
        {
            Include(new EmployeeRequestDtoValidator());
            RuleFor(a => a.Id).NotNull().NotEmpty().WithMessage("{PropertyName} must be Not Empty");
        }
    }
}
