using FluentValidation;

namespace HrLeaveManagement.Application.DTOs.Department.Validators
{
    public class CreateDepartmentRequestDtoValidator : AbstractValidator<IDepartmentRequestDto>
    {


        public CreateDepartmentRequestDtoValidator()
        {
          
            Include(new IDepartmentRequestDtoValidator());

        }
    }
}


