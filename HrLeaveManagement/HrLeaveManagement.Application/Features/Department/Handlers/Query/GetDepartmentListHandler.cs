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
    public class GetDepartmentListHandler : IRequestHandler<GetDepartmentList, List<DepartmentRequestDto>>
    {
        private readonly IMapper mapper;
        private readonly IDepartmentRepository departmentRepository;

        public GetDepartmentListHandler(IMapper mapper,IDepartmentRepository departmentRepository)
        {
            this.mapper = mapper;
            this.departmentRepository = departmentRepository;
        }
        public async Task<List<DepartmentRequestDto>> Handle(GetDepartmentList request, CancellationToken cancellationToken)
        {
            var DepartmentList = await departmentRepository.GetListDepartmentAndEmpByName(request.Name);
            return mapper.Map<List<DepartmentRequestDto>>(DepartmentList);
        }
    }
}
