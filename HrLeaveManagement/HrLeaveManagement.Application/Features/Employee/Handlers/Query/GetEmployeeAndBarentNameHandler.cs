using AutoMapper;
using HrLeaveManagement.Application.DTOs.Employee;
using HrLeaveManagement.Application.Features.Employee.Request.Query;
using HrLeaveManagement.Application.Presistanse.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace HrLeaveManagement.Application.Features.Employee.Handlers.Query
{
    public class GetEmployeeAndBarentNameHandler : IRequestHandler<GetEmployeeAndParent, EmployeeAndParentDto>
    {
        private readonly IMapper mapper;
        private readonly IEmployeeRepository employeeRepository;

        public GetEmployeeAndBarentNameHandler(IMapper mapper, IEmployeeRepository employeeRepository)
        {
            this.mapper = mapper;
            this.employeeRepository = employeeRepository;
        }
        public async Task<EmployeeAndParentDto> Handle(GetEmployeeAndParent request, CancellationToken cancellationToken)
        {
            var Emp = await employeeRepository.GetEmployeeAndBarentDep(request.Id);

            return mapper.Map<EmployeeAndParentDto>(Emp);
        }
    }
}
