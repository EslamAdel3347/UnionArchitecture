using HrLeaveManagement.Application.Presistanse.Contracts;
using HrLeaveManagement.Presistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrLeaveManagement.Presistance
{
    public static class PersistenceServicesRegisteration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration) {


            services.AddDbContext<leaveManagementDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("LeaveManagementConnectionString")));




            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<ILeaveRequestRepository, LeaveRequestRepository>();
            services.AddScoped<ILeaveTypeRepository , LeaveTypeRepository>();
            services.AddScoped<ILeaveAllocationRepository, LeaveAllocationRepository>();

            services.AddScoped<IDepartmentRepository, DepartmentRepository>();


            return services;
        }
    }
}
