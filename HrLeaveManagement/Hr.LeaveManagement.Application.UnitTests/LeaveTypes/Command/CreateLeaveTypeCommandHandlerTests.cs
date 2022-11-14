using AutoMapper;
using Hr.LeaveManagement.Application.UnitTests.Mocks;
using HrLeaveManagement.Application.DTOs;
using HrLeaveManagement.Application.Features.LeaveTypes.Handlers.Commands;
using HrLeaveManagement.Application.Features.LeaveTypes.Requests;
using HrLeaveManagement.Application.Presistanse.Contracts;
using HrLeaveManagement.Application.Profiles;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Hr.LeaveManagement.Application.UnitTests.LeaveTypes.Command
{
    public class CreateLeaveTypeCommandHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<ILeaveTypeRepository> _mockRepo;
        private readonly CreateLeaveTypeDto _leaveTypeDto;
        private readonly CreateLeaveTypeCommandHandler _handler;

        public CreateLeaveTypeCommandHandlerTests()
        {
            _mockRepo = MockLeaveTypeRepository.GetLeaveTypeRepository();

            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<MappingProfile>();
            });

            _mapper = mapperConfig.CreateMapper();
            _handler = new CreateLeaveTypeCommandHandler(_mockRepo.Object, _mapper);

            _leaveTypeDto = new CreateLeaveTypeDto
            {
                DefaultDays = 15,
                Name = "Test DTO"
            };
        }

        [Fact]
        public async Task Valid_LeaveType_Added()
        {
            var result = await _handler.Handle(new CreateLeaveTypeCommand() { CreateLeaveTypeDto = _leaveTypeDto }, CancellationToken.None);

            var leaveTypes = await _mockRepo.Object.GetAll();

            result.ShouldBeOfType<int>();

            leaveTypes.Count.ShouldBe(3);
        }

        [Fact]
        public async Task InValid_LeaveType_Added()
        {
            _leaveTypeDto.DefaultDays = -1;

            ValidationException ex = await Should.ThrowAsync<ValidationException>
                (async () =>
                       await _handler.Handle(new CreateLeaveTypeCommand() { CreateLeaveTypeDto = _leaveTypeDto }, CancellationToken.None)
                );

            var leaveTypes = await _mockRepo.Object.GetAll();

            leaveTypes.Count.ShouldBe(3);

            ex.ShouldNotBeNull();
        }
    }
}
