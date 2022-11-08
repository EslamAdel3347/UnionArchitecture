using AutoMapper;
using HrLeaveManagement.Application.Exceptions;
using HrLeaveManagement.Application.Features.LeaveAllocation.Requests;
using HrLeaveManagement.Application.Presistanse.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace HrLeaveManagement.Application.Features.LeaveAllocation.Handlers.Commands
{
    public class DeleteLeaveAllocationHandler : IRequestHandler<DeleteLeaveAllocationDetailsCommand>
    {
        private readonly ILeaveAllocationRepository leaveAllocationRepository;
        private readonly IMapper mapper;

        public DeleteLeaveAllocationHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            this.leaveAllocationRepository = leaveAllocationRepository;
            this.mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteLeaveAllocationDetailsCommand request, CancellationToken cancellationToken)
        {
            var LeaveAllocation = await leaveAllocationRepository.Get(request.Id);

            if (LeaveAllocation == null)
            {
                throw new NotFoundExceptions(nameof(LeaveAllocation), request.Id);
            }

            await leaveAllocationRepository.Delete(LeaveAllocation);

            return Unit.Value;
        }
    }
}
