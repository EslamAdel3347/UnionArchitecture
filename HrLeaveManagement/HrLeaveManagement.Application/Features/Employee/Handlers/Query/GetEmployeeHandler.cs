using AutoMapper;
using HrLeaveManagement.Application.DTOs.Employee;
using HrLeaveManagement.Application.Features.Employee.Request.Query;
using HrLeaveManagement.Application.Presistanse.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HrLeaveManagement.Application.Features.Employee.Handlers.Query
{
    public class GetEmployeeHandler : IRequestHandler<GetEmployee, EmployeeRequestDto>
    {
        private readonly IMapper mapper;
        private readonly IEmployeeRepository employeeRepository;

        public GetEmployeeHandler(IMapper mapper,IEmployeeRepository employeeRepository )
        {
            this.mapper = mapper;
            this.employeeRepository = employeeRepository;
        }
        public async Task<EmployeeRequestDto> Handle(GetEmployee request, CancellationToken cancellationToken)
        {
            var Emp = await employeeRepository.Get(request.Id);

            return mapper.Map<EmployeeRequestDto>(Emp);
        }
    }
}
