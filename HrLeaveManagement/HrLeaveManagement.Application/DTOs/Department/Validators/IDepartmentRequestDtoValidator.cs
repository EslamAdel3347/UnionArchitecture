using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrLeaveManagement.Application.DTOs.Department.Validators
{
    public  class  IDepartmentRequestDtoValidator:AbstractValidator<IDepartmentRequestDto>
    {
        public IDepartmentRequestDtoValidator()
        {
            RuleFor(a => a.DepName).NotEmpty().WithMessage("{PropertyName} must not be empty")
                .NotNull()
                .MaximumLength(50).WithMessage("Max length should be 50");
            RuleFor(a => a.DepartmentAddress).Empty().WithMessage("{PropertyName must contain at lease one element}");
        }
    }

}
