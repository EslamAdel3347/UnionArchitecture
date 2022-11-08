using AutoMapper;
using HrLeaveManagement.Application.Exceptions;
using HrLeaveManagement.Application.Features.LeaveRequest.Request;
using HrLeaveManagement.Application.Presistanse.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace HrLeaveManagement.Application.Features.LeaveRequest.Handlers
{
    public class DeleteLeaveRequestHandlers : IRequestHandler<DeleteLeaveRequestCommand>
    {
        private readonly ILeaveRequestRepository leaveRequestRepository;
        private readonly IMapper mapper;
        public DeleteLeaveRequestHandlers(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            this.leaveRequestRepository = leaveRequestRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteLeaveRequestCommand request, CancellationToken cancellationToken)
        {


            var LeaveRequest1 = await leaveRequestRepository.Get(request.ID);

            if (LeaveRequest1==null)
            {
                throw new NotFoundExceptions(nameof(LeaveRequest),request.ID);
            }

               
                await leaveRequestRepository.Delete(LeaveRequest1);
         
         



            return Unit.Value;

        }
    }
}
