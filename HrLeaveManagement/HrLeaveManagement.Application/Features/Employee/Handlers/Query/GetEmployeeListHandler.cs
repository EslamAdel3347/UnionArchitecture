using AutoMapper;
using HrLeaveManagement.Application.DTOs.Employee;
using HrLeaveManagement.Application.Features.Employee.Request.Query;
using HrLeaveManagement.Application.Presistanse.Contracts;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HrLeaveManagement.Application.Features.Employee.Handlers.Query
{
    public class GetEmployeeListHandler : IRequestHandler<GetEmployeeList, List<EmployeeRequestDto>>
    {
        private readonly IMapper mapper;
        private readonly IEmployeeRepository employeeRepository;

        public GetEmployeeListHandler(IMapper mapper, IEmployeeRepository employeeRepository)
        {
            this.mapper = mapper;
            this.employeeRepository = employeeRepository;
        }

        public async Task<List<EmployeeRequestDto>> Handle(GetEmployeeList request, CancellationToken cancellationToken)
        {
            var EmpList =await employeeRepository.GetAll();

            return mapper.Map<List<EmployeeRequestDto>>(EmpList);
        }

    }




}
