using AutoMapper;
using HrLeaveManagement.Application.DTOs;
using HrLeaveManagement.Application.DTOs.LeaveType.Validators;
using HrLeaveManagement.Application.Exceptions;
using HrLeaveManagement.Application.Features.LeaveTypes.Requests;
using HrLeaveManagement.Application.Presistanse.Contracts;
using HrLeaveManagement.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HrLeaveManagement.Application.Features.LeaveTypes.Handlers.Commands
{
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
    {
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly IMapper mapper;

        public CreateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository,IMapper mapper)
        {
            this.leaveTypeRepository = leaveTypeRepository;
            this.mapper = mapper;
        }

        public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var Validator = new CreateLeaveTypeValidator();
            var ValidationResult =await Validator.ValidateAsync(request.CreateLeaveTypeDto);
            if (ValidationResult.IsValid == false)
                throw new ValidationExceptions(ValidationResult);

            var LeaveType = mapper.Map<LeaveType>(request.CreateLeaveTypeDto);
            LeaveType = await leaveTypeRepository.Add(LeaveType);
            return LeaveType.Id;

        }
    }
}
