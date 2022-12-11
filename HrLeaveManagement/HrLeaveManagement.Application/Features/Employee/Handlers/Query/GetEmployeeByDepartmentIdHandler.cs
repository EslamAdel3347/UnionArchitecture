using AutoMapper;
using HrLeaveManagement.Application.DTOs.Employee;
using HrLeaveManagement.Application.Features.Employee.Request.Query;
using HrLeaveManagement.Application.Presistanse.Contracts;
using MediatR;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HrLeaveManagement.Application.Features.Employee.Handlers.Query
{
    public class GetEmployeeByDepartmentIdHandler : IRequestHandler<GetEmployeeByDepartmentId, EmployeeRequestDto>
    {
        private readonly IMapper mapper;
        private readonly IEmployeeRepository employeeRepository;

        public GetEmployeeByDepartmentIdHandler(IMapper mapper, IEmployeeRepository employeeRepository)
        {
            this.mapper = mapper;
            this.employeeRepository = employeeRepository;
        }

        public async Task<EmployeeRequestDto> Handle(GetEmployeeByDepartmentId request, CancellationToken cancellationToken)
        {
            var Emp = await employeeRepository.GetEmployeeByDepartmentID(request.DepartmentID);

            return mapper.Map<EmployeeRequestDto>(Emp);
        }
    }




}
