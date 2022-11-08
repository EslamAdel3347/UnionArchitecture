using System;
using System.Collections.Generic;
using System.Text;

namespace HrLeaveManagement.Application.Exceptions
{
    public class BadRequestExceptions:ApplicationException
    {
        public BadRequestExceptions(string Message):base(Message)
        {
                
        }
    } 
}
