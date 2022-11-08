using AutoMapper;
using HrLeaveManagement.Application.DTOs;
using HrLeaveManagement.Application.DTOs.LeaveType.Validators;
using HrLeaveManagement.Application.Exceptions;
using HrLeaveManagement.Application.Features.LeaveTypes.Requests.Command;
using HrLeaveManagement.Application.Presistanse.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HrLeaveManagement.Application.Features.LeaveTypes.Handlers.Commands
{
    public class UpdateLeaveTypeCommandHandler : IRequestHandler<UpdateLeaveTypeCommand, Unit>
    {
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly IMapper mapper;

        public UpdateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository,IMapper mapper)
        {
            this.leaveTypeRepository = leaveTypeRepository;
            this.mapper = mapper;
        }


        public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var Validator = new UpdateLeaveTypeValidator();
            var ValidationResult = await Validator.ValidateAsync(request.LeaveTypeDto);
            if (ValidationResult.IsValid == false)
                throw new ValidationExceptions(ValidationResult);

            var LeaveType = await leaveTypeRepository.Get(request.LeaveTypeDto.Id);
            mapper.Map(request.LeaveTypeDto, LeaveType);

            await leaveTypeRepository.Update(LeaveType);


            return Unit.Value;
        }
    }
}
