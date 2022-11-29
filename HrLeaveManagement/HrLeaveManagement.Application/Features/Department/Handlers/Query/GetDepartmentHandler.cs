using AutoMapper;
using HrLeaveManagement.Application.DTOs.Department;
using HrLeaveManagement.Application.Features.Department.Requests.Query;
using HrLeaveManagement.Application.Presistanse.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HrLeaveManagement.Application.Features.Department.Handlers.Query
{
    public class GetDepartmentHandler : IRequestHandler<GetDepartment, DepartmentRequestDto>
    {
        private readonly IMapper mapper;
        private readonly IDepartmentRepository departmentRepository;

        public GetDepartmentHandler(IMapper mapper,IDepartmentRepository departmentRepository)
        {
            this.mapper = mapper;
            this.departmentRepository = departmentRepository;
        }

        public async Task<DepartmentRequestDto> Handle(GetDepartment request, CancellationToken cancellationToken)
        {

            var Department = await departmentRepository.GetDepartmentByName(request.Name);

            return mapper.Map<DepartmentRequestDto>(Department);

           
        }
    }
}
