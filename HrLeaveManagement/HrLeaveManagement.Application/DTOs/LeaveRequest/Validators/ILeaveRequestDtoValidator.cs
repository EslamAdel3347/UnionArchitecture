using FluentValidation;
using HrLeaveManagement.Application.Presistanse.Contracts;

namespace HrLeaveManagement.Application.DTOs.LeaveRequest.Validators
{
    public class ILeaveRequestDtoValidator : AbstractValidator<ILeaveRequestDto>
    {
        private readonly ILeaveTypeRepository leaveTypeRepository;

        public ILeaveRequestDtoValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            this.leaveTypeRepository = leaveTypeRepository;
            RuleFor(a => a.StartDate)
                .LessThan(a => a.EndDate).WithMessage("{PropertyName} must be before {ComparisonValue}");

            RuleFor(a => a.EndDate)
              .GreaterThan(a => a.StartDate).WithMessage("{PropertyName} must be after {ComparisonValue}");

            RuleFor(a => a.LeaveTypeID)
                .GreaterThan(0)
              .MustAsync(async (id, token) =>
              {
                  var Leavetypeexits = await leaveTypeRepository.Exits(id);
                  return !Leavetypeexits;
              }).WithMessage("{PropertyName} does not exits");

        }
    }
}
