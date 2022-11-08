using AutoMapper;
using HrLeaveManagement.Application.DTOs.LeaveRequest.Validators;
using HrLeaveManagement.Application.Exceptions;
using HrLeaveManagement.Application.Features.LeaveRequest.Request;
using HrLeaveManagement.Application.Presistanse.Contracts;
using HrLeaveManagement.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HrLeaveManagement.Application.Features.LeaveRequest.Handlers
{
    public class CreateLeaveRequestHandlers : IRequestHandler<CreateLeaveRequestCommand, BaseCommandResponse>
    {
        private readonly ILeaveRequestRepository leaveRequestRepository;
        private readonly IMapper mapper;
        private readonly ILeaveTypeRepository leaveTypeRepository;

        public CreateLeaveRequestHandlers(ILeaveRequestRepository leaveRequestRepository, IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            this.leaveRequestRepository = leaveRequestRepository;
            this.mapper = mapper;
            this.leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<BaseCommandResponse> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var Response = new BaseCommandResponse();
            var Validator = new CreateLeaveRequestDtoValidator(leaveTypeRepository);
            var ValidationResult = await Validator.ValidateAsync(request.CreateLeaveRequestDto);
            if (ValidationResult.IsValid == false) {

                Response.Success = false;
                Response.Message = "Creation Failed";
                Response.Errors = ValidationResult.Errors.Select(a => a.ErrorMessage).ToList();
            
            }


            var LeaveRequest = mapper.Map<HrLeaveManagement.Domain.LeaveRequest>(request.CreateLeaveRequestDto);

            LeaveRequest = await leaveRequestRepository.Add(LeaveRequest);

            Response.Success = true;
            Response.Message = "Creation Successful";
            Response.Id = LeaveRequest.Id;
            return Response;
            
        }
    }
}
