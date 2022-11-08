using HrLeaveManagement.Application.Profiles;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace HrLeaveManagement.Application
{
    public static class ApplicationServicesRegisteration
    {
        public static IServiceCollection  ConfigureApplicationServices(this IServiceCollection service)
        {
            service.AddAutoMapper(typeof(MappingProfile));
            service.AddMediatR(Assembly.GetExecutingAssembly()); 
            return service;
        }
    }
}
