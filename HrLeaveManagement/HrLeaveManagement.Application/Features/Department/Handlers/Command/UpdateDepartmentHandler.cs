using AutoMapper;
using HrLeaveManagement.Application.DTOs.Department;
using HrLeaveManagement.Application.DTOs.Department.Validators;
using HrLeaveManagement.Application.Features.Department.Requests.Command;
using HrLeaveManagement.Application.Presistanse.Contracts;
using HrLeaveManagement.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HrLeaveManagement.Application.Features.Department.Handlers.Command
{
    public class UpdateDepartmentHandler : IRequestHandler<UpdateDepartmentCommand, BaseCommandResponse>
    {
        private readonly IMapper mapper;
        private readonly IDepartmentRepository departmentRepository;

        public UpdateDepartmentHandler(IMapper mapper,IDepartmentRepository departmentRepository)
        {
            this.mapper = mapper;
            this.departmentRepository = departmentRepository;
        }
        public async Task<BaseCommandResponse> Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var Response = new BaseCommandResponse();

            #region validate dto and deoartment was found

            var Validator = new CreateDepartmentRequestDtoValidator();
            var validationResult =await Validator.ValidateAsync(request.UpdateDepartmentRequest);

            if (!validationResult.IsValid)
            {
                Response.Success = false;
                Response.Message = "Department Not valid";
                Response.Id = request.Id;
                Response.Errors = validationResult.Errors.Select(a => a.ErrorMessage).ToList() ;
            }


            var department = await departmentRepository.Get(request.Id);

      
            if (department==null)
            {
                Response.Success = false;
                Response.Message = "Department Not Found";
                Response.Id = request.Id;
                Response.Errors = new List<string> { new string("Department not found that match id") };

            }

            #endregion

            var newDepartment = mapper.Map<HrLeaveManagement.Domain.Department>(request.UpdateDepartmentRequest);
            newDepartment = await departmentRepository.Update(newDepartment);

            Response.Success = true;
            Response.Id = request.Id;
            Response.Message = "Created Successfully";


            return Response;
        }
    }
}
