using FluentValidation;

namespace HrLeaveManagement.Application.DTOs.Employee.Validators
{
    public class CreateEmployeeRequestDtoValidator : AbstractValidator<EmployeeRequestDto>
    {
        public CreateEmployeeRequestDtoValidator()
        {
            Include(new EmployeeRequestDtoValidator());

        }
    }
}
