using FluentValidation;
using HrLeaveManagement.Application.Presistanse.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrLeaveManagement.Application.DTOs.LeaveAllocation.Validators
{
    public class ILeaveAllocationDtoValidator:AbstractValidator<ILeaveAllocationDto>
    {
        private readonly ILeaveTypeRepository leaveTypeRepository;

        public ILeaveAllocationDtoValidator(ILeaveTypeRepository leaveTypeRepository )
        {
            this.leaveTypeRepository = leaveTypeRepository;
            RuleFor(a => a.Period).GreaterThanOrEqualTo(DateTime.Now.Year).WithMessage("{PropertyName} must Be greater than {ComparisonValue}");
            RuleFor(a => a.NumberOfDays).GreaterThan(0).WithMessage("{PropertyName} must be greater than {ComparionValue} ");

            RuleFor(a => a.LeaveTypeId).GreaterThan(0)
                .MustAsync(async (id, token) =>
                {

                    var LeaveType = await leaveTypeRepository.Exits(id);
                    return !LeaveType;

                }).WithMessage("{PropertyName} does not exits");

        }
    }
}
