using FluentValidation;

namespace HrLeaveManagement.Application.DTOs.Department.Validators
{
    public class UpdateDepartmentRequestDtoValidator : AbstractValidator<UpdateDepartmentRequestDto>
    {
        public UpdateDepartmentRequestDtoValidator()
        {
            Include(new IDepartmentRequestDtoValidator());

            RuleFor(a => a.Id).NotNull().WithMessage("{PropertyName} must be Not Empty");

        }


    }
}


