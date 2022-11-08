using AutoMapper;
using HrLeaveManagement.Application.DTOs.LeaveAllocation.Validators;
using HrLeaveManagement.Application.Exceptions;
using HrLeaveManagement.Application.Features.LeaveAllocation.Requests;
using HrLeaveManagement.Application.Presistanse.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HrLeaveManagement.Application.Features.LeaveAllocation.Handlers.Commands
{
    public class CreateLeaveAllocationHandler : IRequestHandler<CreateLeaveAllocationDetailsCommand, int>
    {
        private readonly ILeaveAllocationRepository leaveAllocationRepository;
        private readonly IMapper mapper;
        private readonly ILeaveTypeRepository leaveTypeRepository;

        public CreateLeaveAllocationHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            this.leaveAllocationRepository = leaveAllocationRepository;
            this.mapper = mapper;
            this.leaveTypeRepository = leaveTypeRepository;
        }
        public async Task<int> Handle(CreateLeaveAllocationDetailsCommand request, CancellationToken cancellationToken)
        {
            var Validator = new CreateLeaveAllocationDtoValidator(leaveTypeRepository);
            var ValidationResult = await Validator.ValidateAsync(request.CreateLeaveAllocationDto);
            if (ValidationResult.IsValid == false)
                throw new ValidationExceptions(ValidationResult);

            var LeaveAllocation = mapper.Map<Domain.LeaveAllocation>(request.CreateLeaveAllocationDto);
            LeaveAllocation = await leaveAllocationRepository.Add(LeaveAllocation);
            return LeaveAllocation.Id;
        }
    }
}
