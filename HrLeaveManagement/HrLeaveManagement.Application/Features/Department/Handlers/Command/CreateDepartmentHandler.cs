using AutoMapper;
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
    public class CreateDepartmentHandler : IRequestHandler<CreateDepartmentCommand, BaseCommandResponse>
    {
        private readonly IMapper mapper;
        private readonly IDepartmentRepository departmentRepository;

        public CreateDepartmentHandler(IMapper mapper,IDepartmentRepository departmentRepository)
        {
            this.mapper = mapper;
            this.departmentRepository = departmentRepository;
        }

        public async Task<BaseCommandResponse> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var Response = new BaseCommandResponse();


            //validate request

            var Validator = new CreateDepartmentRequestDtoValidator();



            var result =await Validator.ValidateAsync(request.CreateDepartmentRequest);

            if (result.IsValid == false)
            {

                Response.Success = false;
                Response.Message = "Creation Failed";
                Response.Errors = result.Errors.Select(a => a.ErrorMessage).ToList();

            }


            /// end of request validate
            /// 
            #region add request

            var Department = mapper.Map<HrLeaveManagement.Domain.Department>(request.CreateDepartmentRequest);

            Department =await departmentRepository.Add(Department);


            #endregion

            #region response part
            Response.Success = true;
            Response.Message = "Creation Successful";
            Response.Id = Department.Id;
            #endregion
            return Response;
        }
    }
}
