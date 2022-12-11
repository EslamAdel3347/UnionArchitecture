using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrLeaveManagement.Application.DTOs.Employee.Validators
{
    public class EmployeeRequestDtoValidator:AbstractValidator<EmployeeRequestDto>
    {
        public EmployeeRequestDtoValidator()
        {
            RuleFor(a => a.EmpName).NotEmpty().WithMessage("{PropertyName} must not be empty")
             .NotNull()
             .MaximumLength(50).WithMessage("Max length should be 50");
            RuleFor(a => a.EmpAddress).Empty().WithMessage("{PropertyName must contain at lease one element}");
            RuleFor(a => a.EmpAddress).Empty().WithMessage("{PropertyName must contain at lease one element}");

        }
    }
}
