using AutoMapper;
using HrLeaveManagement.Application.Features.Department.Requests.Command;
using HrLeaveManagement.Application.Presistanse.Contracts;
using HrLeaveManagement.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HrLeaveManagement.Application.Features.Department.Handlers.Command
{
    public class DeleteDepartmentHandler : IRequestHandler<DeleteDepartmentCommand,BaseCommandResponse>
    {
        private readonly IMapper mapper;
        private readonly IDepartmentRepository departmentRepository;

        public DeleteDepartmentHandler(IMapper mapper,IDepartmentRepository departmentRepository)
        {
            this.mapper = mapper;
            this.departmentRepository = departmentRepository;
        }

        public async Task<BaseCommandResponse> Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();

            var CheckDepartment =await departmentRepository.Get(request.Id);

            if (CheckDepartment==null)
            {
                response.Success = false;
                response.Id = request.Id;
                response.Message = "department was not found";
                return response;
            }

            var Request = await departmentRepository.Delete(CheckDepartment);


            response.Success = true;
            response.Id = request.Id;
            response.Message = "department was deleted ";
            return response;

        }
    }
}
