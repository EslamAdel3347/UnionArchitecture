using AutoMapper;
using HrLeaveManagement.Application.DTOs.Employee;
using HrLeaveManagement.Application.Features.Employee.Request.Query;
using HrLeaveManagement.Application.Presistanse.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace HrLeaveManagement.Application.Features.Employee.Handlers.Query
{
    public class GetEmployeeByNameHandler : IRequestHandler<GetEmployeeByName, EmployeeRequestDto>
    {
        private readonly IMapper mapper;
        private readonly IEmployeeRepository employeeRepository;

        public GetEmployeeByNameHandler(IMapper mapper, IEmployeeRepository employeeRepository)
        {
            this.mapper = mapper;
            this.employeeRepository = employeeRepository;
        }

        public async Task<EmployeeRequestDto> Handle(GetEmployeeByName request, CancellationToken cancellationToken)
        {
            var Emp = await employeeRepository.GetEmployeeByName(request.Name);

            return mapper.Map<EmployeeRequestDto>(Emp);
        }
    }




}
